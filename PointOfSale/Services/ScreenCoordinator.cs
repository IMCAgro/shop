﻿using Caliburn.Micro;
using Shop.Contracts.Entities;
using Shop.PointOfSale.Models;
using Shop.PointOfSale.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.PointOfSale.Services
{
    public class ScreenCoordinator
    {
        public ScreenCoordinator(IEventAggregator eventAggregator)
	    {
            EventAggregator = eventAggregator;
            Logger = log4net.LogManager.GetLogger(GetType());
	    }

        private readonly IEventAggregator EventAggregator;

        private readonly log4net.ILog Logger;

        public void NavigateToScreen(Screen screen)
        {
            EventAggregator.Publish(screen);
        }

        public void NavigateToHome()
        {
            var screen = IoC.Get<HomeViewModel>();

            NavigateToScreen(screen);
        }

        public void NavigateToCustomer(Customer customer)
        {
            var screen = IoC.Get<CustomerViewModel>();
            screen.Customer = customer;

            NavigateToScreen(screen);
        }

        public void HandleFault(AggregateException ex)
        {
            Logger.Error(ex.Message, ex);

            var message = IoC.Get<MessageBoxViewModel>();
            message.DisplayName = "Error";
            message.Content = new ErrorInfo();
            message.DismissAction = () => NavigateToHome();
            message.DismissTimeout = 10000;

            NavigateToScreen(message);
        }
    }
}
