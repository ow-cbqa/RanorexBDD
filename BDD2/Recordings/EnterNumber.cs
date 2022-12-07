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
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace BDD2.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EnterNumber recording.
    /// </summary>
    [TestModule("7f2525d3-e661-40f8-968d-4daf05d508bb", ModuleType.Recording, 1)]
    public partial class EnterNumber : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::BDD2.BDD2Repository repository.
        /// </summary>
        public static global::BDD2.BDD2Repository repo = global::BDD2.BDD2Repository.Instance;

        static EnterNumber instance = new EnterNumber();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterNumber()
        {
            Input = "50";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterNumber Instance
        {
            get { return instance; }
        }

#region Variables

        string _Input;

        /// <summary>
        /// Gets or sets the value of variable Input.
        /// </summary>
        [TestVariable("ff34e5a4-8416-44d8-80dd-083375cdddb8")]
        public string Input
        {
            get { return _Input; }
            set { _Input = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Mouse_Click_Screen(repo.Calculadora.ScreenInfo);
            Delay.Milliseconds(0);
            
            Key_sequence_Calculadora(repo.Calculadora.SelfInfo, Input);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}