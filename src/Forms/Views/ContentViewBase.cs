﻿using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using ReactiveUI;
using ReactiveUI.XamForms;
using Splat;

namespace Rocket.Surgery.Airframe.Forms
{
    /// <summary>
    /// Base ReactiveUI <see cref="ReactiveContentView{TViewModel}"/>.
    /// </summary>
    /// <typeparam name="TViewModel">The type of the view model.</typeparam>
    /// <seealso cref="ReactiveContentView{TViewModel}" />
    [SuppressMessage("Microsoft.Usage",  "CA2214:VirtualMemberCallInConstructor", Justification = "Consumers should be aware methods are for object construction.")]
    public abstract class ContentViewBase<TViewModel> : ReactiveContentView<TViewModel>, IEnableLogger
        where TViewModel : class, IReactiveObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentViewBase{TViewModel}"/> class.
        /// </summary>
        [SuppressMessage("ReSharper", "VirtualMemberCallInConstructor", Justification = "Consumers should be aware methods are for object construction.")]
        protected ContentViewBase()
        {
            Logger = this.Log();
            Initialize();
            BindControls();
            RegisterObservers();
        }

        /// <summary>
        /// Gets or sets the <see cref="IFullLogger"/>.
        /// </summary>
        public IFullLogger Logger { get; protected set; }

        /// <summary>
        /// Gets the view bindings disposable.
        /// </summary>
        protected CompositeDisposable ViewBindings { get; } = new CompositeDisposable();

        /// <summary>
        /// View lifecycle method that registers observers via subscriptions.
        /// </summary>
        protected virtual void RegisterObservers()
        {
        }

        /// <summary>
        /// View lifecycle method that sets up reactive bindings.
        /// </summary>
        protected virtual void BindControls()
        {
        }

        /// <summary>
        /// View lifecycle method that initializes the view.
        /// </summary>
        protected virtual void Initialize()
        {
        }
    }
}
