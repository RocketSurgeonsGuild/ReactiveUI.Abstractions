using System.Reactive.Disposables;
using ReactiveUI;
using UIKit;

namespace Rocket.Surgery.Airframe
{
    /// <summary>
    /// Base reactive <see cref="UITableView"/>.
    /// </summary>
    /// <typeparam name="TViewModel">The type of the view model.</typeparam>
    /// <seealso cref="ReactiveTableView{TViewModel}" />
    public abstract class TableViewBase<TViewModel> : ReactiveTableView<TViewModel>
        where TViewModel : class, IReactiveObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewBase{TViewModel}"/> class.
        /// </summary>
        protected TableViewBase()
        {
            Initialize();
            BindControls();
            RegisterObservers();
        }

        /// <summary>
        /// Gets the control bindings disposable.
        /// </summary>
        protected CompositeDisposable ViewBindings { get; } = new CompositeDisposable();

        /// <summary>
        /// View lifecycle method that initializes the view controller.
        /// </summary>
        protected virtual void Initialize()
        {
        }

        /// <summary>
        /// View lifecycle method that sets up reactive bindings.
        /// </summary>
        protected abstract void BindControls();

        /// <summary>
        /// View lifecycle method that registers observers via subscriptions.
        /// </summary>
        protected abstract void RegisterObservers();
    }
}