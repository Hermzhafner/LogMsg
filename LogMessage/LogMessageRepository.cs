﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace LogMessage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the LogMessageRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    [RepositoryFolder("c531d237-eeef-499a-924c-0d9a71241ab1")]
    public partial class LogMessageRepository : RepoGenBaseFolder
    {
        static LogMessageRepository instance = new LogMessageRepository();

        /// <summary>
        /// Gets the singleton class instance representing the LogMessageRepository element repository.
        /// </summary>
        [RepositoryFolder("c531d237-eeef-499a-924c-0d9a71241ab1")]
        public static LogMessageRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public LogMessageRepository() 
            : base("LogMessageRepository", "/", null, 0, false, "c531d237-eeef-499a-924c-0d9a71241ab1", ".\\RepositoryImages\\LogMessageRepositoryc531d237.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("c531d237-eeef-499a-924c-0d9a71241ab1")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    public partial class LogMessageRepositoryFolders
    {
    }
#pragma warning restore 0436
}