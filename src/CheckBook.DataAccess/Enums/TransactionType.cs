﻿
namespace CheckBook.DataAccess.Enums
{
    public enum TransactionType
    {
        /// <summary>
        /// Somebody paid certain amount for somebody else
        /// </summary>
        Payment,

        /// <summary>
        /// Auto-generated transaction which splits the remaining amount to all people in the group
        /// </summary>
        AutoGeneratedRounding
    }
}
