﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;

using Foundation;
using ReactiveUI;
using UIKit;

namespace Rocket.Surgery.Airframe
{
    /// <summary>
    /// Base reactive <see cref="UITableViewController"/>.
    /// </summary>
    /// <typeparam name="TViewModel">The type of the view model.</typeparam>
    /// <seealso cref="ReactiveTableViewController{TViewModel}" />
    public abstract class TableViewControllerBase<TViewModel> : ReactiveTableViewController<TViewModel>
        where TViewModel : class, IReactiveObject
    {
        private ISubject<bool> _appeared;
        private ISubject<bool> _disappeared;
        private ISubject<bool> _appearing;
        private ISubject<bool> _disappearing;

        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewControllerBase{TViewModel}"/> class.
        /// </summary>
        protected TableViewControllerBase()
        {
        }

        /// <summary>
        /// Gets the bindings disposable.
        /// </summary>
        protected CompositeDisposable ViewBindings { get; } = new CompositeDisposable();

        /// <summary>
        /// Gets an observable sequence when the view is appearing.
        /// </summary>
        /// <returns>The appearing notification.</returns>
        public virtual IObservable<bool> Appearing() => _appearing.AsObservable();

        /// <summary>
        /// Gets an observable sequence when the view is disappearing.
        /// </summary>
        /// <returns>The appearing notification.</returns>
        public virtual IObservable<bool> Appeared() => _appeared.AsObservable();

        /// <summary>
        /// Gets an observable sequence when the view is appearing.
        /// </summary>
        /// <returns>The appearing notification.</returns>
        public virtual IObservable<bool> Disappeared() => _disappeared.AsObservable();

        /// <summary>
        /// Gets an observable sequence when the view is disappearing.
        /// </summary>
        /// <returns>The appearing notification.</returns>
        public virtual IObservable<bool> Disappearing() => _disappearing.AsObservable();

        /// <inheritdoc />
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            _appearing.OnNext(animated);
        }

        /// <inheritdoc />
        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            _disappearing.OnNext(animated);
        }

        /// <inheritdoc />
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            _appeared.OnNext(animated);
        }

        /// <inheritdoc />
        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            _disappeared.OnNext(animated);
        }

        /// <inheritdoc/>
        public override void ViewDidLoad()
        {
            _appearing = new Subject<bool>();
            _disappearing = new Subject<bool>();
            _appeared = new Subject<bool>();
            _disappeared = new Subject<bool>();
            Initialize();
            CreateUserInterface();
            BindControls();
            RegisterObservers();
            LoadTableSource();
        }

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
        /// View lifecycle method that creates the user interface.
        /// </summary>
        protected abstract void CreateUserInterface();

        /// <summary>
        /// View lifecycle method that registers observers via subscriptions.
        /// </summary>
        protected abstract void RegisterObservers();

        /// <summary>
        /// Loads the table source.
        /// </summary>
        protected abstract void LoadTableSource();
    }
}