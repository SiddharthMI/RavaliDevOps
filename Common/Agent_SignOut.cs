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

namespace Sid_FCGAProject.Common
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Agent_SignOut recording.
    /// </summary>
    [TestModule("ce76a3a8-4155-4f4f-b5b5-ddba3042c8bc", ModuleType.Recording, 1)]
    public partial class Agent_SignOut : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static Agent_SignOut instance = new Agent_SignOut();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Agent_SignOut()
        {
            Status_Reason = "Agent SignOut";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Agent_SignOut Instance
        {
            get { return instance; }
        }

#region Variables

        string _Status_Reason;

        /// <summary>
        /// Gets or sets the value of variable Status_Reason.
        /// </summary>
        [TestVariable("9b76faa5-390c-4d59-83d4-365718b8228a")]
        public string Status_Reason
        {
            get { return _Status_Reason; }
            set { _Status_Reason = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.LnkSignOut'.", repo.ApplicationUnderTest.LnkSignOutInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.LnkSignOut.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsQawinstonFwcinsComFWCPortalP.Close' at Center.", repo.HttpsQawinstonFwcinsComFWCPortalP.CloseInfo, new RecordItemIndex(2));
            repo.HttpsQawinstonFwcinsComFWCPortalP.Close.Click();
            Delay.Milliseconds(0);
            
            //Hardclosebrowser();
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
