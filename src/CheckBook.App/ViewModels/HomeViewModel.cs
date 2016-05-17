﻿using System.Collections.Generic;
using DotVVM.Framework.Runtime.Filters;
using DotVVM.Framework.Controls;
using System.Threading.Tasks;
using CheckBook.DataAccess.Data;
using CheckBook.DataAccess.Services;
using System.Linq;

namespace CheckBook.App.ViewModels
{
    [Authorize]
	public class HomeViewModel : AppViewModelBase
    {

        /// <summary>
        /// Gets the list of groups the current user is assigned in.
        /// </summary>
        public List<GroupData> Groups { get; set; }

        public List<MyTransactionData> MyTransactions { get; set; }

        public override Task PreRender()
        {
            var userId = GetUserId();
            Groups = GroupService.GetGroupsByUser(userId);

            PaymentService.LoadMyTransactions(userId, q => MyTransactions = q.ToList());

            return base.PreRender();
        }
    }
}
