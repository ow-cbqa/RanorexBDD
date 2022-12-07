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

namespace BDD2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the BDD2Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("aba3d134-d690-4e9e-a01a-c85b8b97c0e1")]
    public partial class BDD2Repository : RepoGenBaseFolder
    {
        static BDD2Repository instance = new BDD2Repository();
        BDD2RepositoryFolders.CalculadoraAppFolder _calculadora;

        /// <summary>
        /// Gets the singleton class instance representing the BDD2Repository element repository.
        /// </summary>
        [RepositoryFolder("aba3d134-d690-4e9e-a01a-c85b8b97c0e1")]
        public static BDD2Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public BDD2Repository() 
            : base("BDD2Repository", "/", null, 0, false, "aba3d134-d690-4e9e-a01a-c85b8b97c0e1", ".\\RepositoryImages\\BDD2Repositoryaba3d134.rximgres")
        {
            _calculadora = new BDD2RepositoryFolders.CalculadoraAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("aba3d134-d690-4e9e-a01a-c85b8b97c0e1")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Calculadora folder.
        /// </summary>
        [RepositoryFolder("079dbcec-ae84-41e7-a2e6-6ffc122a2b4a")]
        public virtual BDD2RepositoryFolders.CalculadoraAppFolder Calculadora
        {
            get { return _calculadora; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class BDD2RepositoryFolders
    {
        /// <summary>
        /// The CalculadoraAppFolder folder.
        /// </summary>
        [RepositoryFolder("079dbcec-ae84-41e7-a2e6-6ffc122a2b4a")]
        public partial class CalculadoraAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _screenInfo;
            RepoItemInfo _plusbtnInfo;
            RepoItemInfo _equalsbtnInfo;

            /// <summary>
            /// Creates a new Calculadora  folder.
            /// </summary>
            public CalculadoraAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Calculadora", "/winapp[@packagename='Microsoft.WindowsCalculator']", parentFolder, 30000, null, true, "079dbcec-ae84-41e7-a2e6-6ffc122a2b4a", "")
            {
                _screenInfo = new RepoItemInfo(this, "Screen", "?/?/text[@automationid='CalculatorResults']/container[@automationid='TextContainer']", ".//container[@automationid='TextContainer']", 30000, null, "c58d9142-5d9e-4fda-b32d-2c33a40579ef");
                _plusbtnInfo = new RepoItemInfo(this, "PlusBtn", ".//button[@automationid='plusButton']/text[@name='']", ".//text[@name='']", 30000, null, "f5b0b6ce-b478-4120-97b8-edaed36d78f8");
                _equalsbtnInfo = new RepoItemInfo(this, "EqualsBtn", ".//button[@automationid='equalButton']/text[@name='']", ".//text[@name='']", 30000, null, "03fa4ffa-e15d-4592-ae4c-c35dffc7ee82");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("079dbcec-ae84-41e7-a2e6-6ffc122a2b4a")]
            public virtual Ranorex.WindowsApp Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WindowsApp>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("079dbcec-ae84-41e7-a2e6-6ffc122a2b4a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Screen item.
            /// </summary>
            [RepositoryItem("c58d9142-5d9e-4fda-b32d-2c33a40579ef")]
            public virtual Ranorex.Container Screen
            {
                get
                {
                    return _screenInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Screen item info.
            /// </summary>
            [RepositoryItemInfo("c58d9142-5d9e-4fda-b32d-2c33a40579ef")]
            public virtual RepoItemInfo ScreenInfo
            {
                get
                {
                    return _screenInfo;
                }
            }

            /// <summary>
            /// The PlusBtn item.
            /// </summary>
            [RepositoryItem("f5b0b6ce-b478-4120-97b8-edaed36d78f8")]
            public virtual Ranorex.Text PlusBtn
            {
                get
                {
                    return _plusbtnInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The PlusBtn item info.
            /// </summary>
            [RepositoryItemInfo("f5b0b6ce-b478-4120-97b8-edaed36d78f8")]
            public virtual RepoItemInfo PlusBtnInfo
            {
                get
                {
                    return _plusbtnInfo;
                }
            }

            /// <summary>
            /// The EqualsBtn item.
            /// </summary>
            [RepositoryItem("03fa4ffa-e15d-4592-ae4c-c35dffc7ee82")]
            public virtual Ranorex.Text EqualsBtn
            {
                get
                {
                    return _equalsbtnInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EqualsBtn item info.
            /// </summary>
            [RepositoryItemInfo("03fa4ffa-e15d-4592-ae4c-c35dffc7ee82")]
            public virtual RepoItemInfo EqualsBtnInfo
            {
                get
                {
                    return _equalsbtnInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
