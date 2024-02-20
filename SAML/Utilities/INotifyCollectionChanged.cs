using SAML.Events;

namespace SAML.Utilities
{
    public interface INotifyCollectionChanged
    {
        /// <summary>
        /// An event which fires when the items in a collection have changed
        /// </summary>
        event CollectionChangedEventHandler? CollectionChanged;
    }
}
