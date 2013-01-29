﻿/////////////////////////////////////////////////////////////////////////////////////////////////////
// Original Code by : Michael Dela Cuesta (michael.dcuesta@gmail.com)                              //
// Source Code Available : http://anito.codeplex.com                                               //
//                                                                                                 // 
// This source code is made available under the terms of the Microsoft Public License (MS-PL)      // 
///////////////////////////////////////////////////////////////////////////////////////////////////// 

using System.Data;
using Anito.Data.Common;
using MySql.Data.MySqlClient;

namespace Anito.Data.MySqlClient
{
    public class CommandExecutor : AdoCommandExecutorBase
    {
        protected override IDbConnection NewConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        protected override ITransaction NewTransaction(IDbTransaction transaction)
        {
            return new Transaction(transaction);
        }
    }
}
