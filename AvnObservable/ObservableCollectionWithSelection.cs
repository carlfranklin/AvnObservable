using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AvnObservable;

/// <summary>
/// An ObservableCollection that includes a selected item.
/// Great for data binding
/// </summary>
/// <typeparam name="T"></typeparam>
public class ObservableCollectionWithSelection<T> : ObservableCollection<T> where T : class
{
    // Stores the hash code of the selected item
    private int SelectedItemHashCode = 0;

    // Events
    public event EventHandler<T> SelectedItemChanging;
    public event EventHandler<T> SelectedItemChanged;

    private T selectedItem;

    /// <summary>
    /// Holds an item selected from the collection
    /// </summary>
    public T SelectedItem
    {
        get
        {
            if (selectedItem == null && this.Count > 0)
            {
                SelectedItem = this[0];
            }
            return selectedItem;
        }
        set
        {
            if (value == null) return;
            if (selectedItem != value)
            {
                // Update the currently selected item in the collection
                UpdateSelectedItemInCollection();
                // prevent reentrancy
                updating = true;
                // Update the item
                selectedItem = value;
                // Save the hash code
                SelectedItemHashCode = value.GetHashCode();
                // Notify the UI
                var args = new PropertyChangedEventArgs("SelectedItem");
                OnPropertyChanged(args);
                OnRaiseSelectedItemChangedEvent(value);
                // all done
                updating = false;
            }
        }
    }

    bool updating = false;  // to prevent reentrancy

    /// <summary>
    /// Update the selected item in the collection
    /// </summary>
    public void UpdateSelectedItemInCollection()
    {
        if (updating) return;

        // prevent reentrancy
        updating = true;

        if (SelectedItemHashCode != 0)
        {
            // Get the last item
            var item = (from t in Items
                        where t.GetHashCode() == SelectedItemHashCode
                        select t).FirstOrDefault();
            if (item != null)
            {
                var index = IndexOf(item);
                // replace the item in the list with itself to trigger updates
                base[index] = selectedItem;
                // Raise Changing event
                OnRaiseSelectedItemChangingEvent(selectedItem);
            }
        }

        // all done
        updating = false;
    }

    protected virtual void OnRaiseSelectedItemChangingEvent(T args)
    {
        EventHandler<T> raiseEvent = SelectedItemChanging;

        if (raiseEvent != null)
        {
            raiseEvent(this, args);
        }
    }

    protected virtual void OnRaiseSelectedItemChangedEvent(T args)
    {
        EventHandler<T> raiseEvent = SelectedItemChanged;

        if (raiseEvent != null)
        {
            raiseEvent(this, args);
        }
    }
}
