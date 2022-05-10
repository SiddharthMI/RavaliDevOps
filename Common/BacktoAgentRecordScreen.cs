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
    ///The BacktoAgentRecordScreen recording.
    /// </summary>
    [TestModule("cf9c3b41-8cf2-4a1b-85ab-997c885d58ad", ModuleType.Recording, 1)]
    public partial class BacktoAgentRecordScreen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static BacktoAgentRecordScreen instance = new BacktoAgentRecordScreen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BacktoAgentRecordScreen()
        {
            BusinessInsuredName = "Automation1 TROY TESTFlorida_FWCI_04/26/2022";
            lob = "";
            Status_Reason = "Agent Record Screen";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BacktoAgentRecordScreen Instance
        {
            get { return instance; }
        }

#region Variables

        string _BusinessInsuredName;

        /// <summary>
        /// Gets or sets the value of variable BusinessInsuredName.
        /// </summary>
        [TestVariable("333f8a90-938c-424a-aa41-5846e89f9b84")]
        public string BusinessInsuredName
        {
            get { return _BusinessInsuredName; }
            set { _BusinessInsuredName = value; }
        }

        string _lob;

        /// <summary>
        /// Gets or sets the value of variable lob.
        /// </summary>
        [TestVariable("67e18692-0c89-4d03-9831-fa66791247b5")]
        public string lob
        {
            get { return _lob; }
            set { _lob = value; }
        }

        string _Status_Reason;

        /// <summary>
        /// Gets or sets the value of variable Status_Reason.
        /// </summary>
        [TestVariable("889f72f9-0434-402f-ae09-23250006dcfb")]
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(0));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Next' at Center.", repo.ApplicationUnderTest.NextInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Next.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(2));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Accepted' at Center.", repo.ApplicationUnderTest.AcceptedInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Accepted.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(4));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtSearch1' at Center.", repo.ApplicationUnderTest.TxtSearch1Info, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TxtSearch1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BusinessInsuredName' with focus on 'ApplicationUnderTest.TxtSearch1'.", repo.ApplicationUnderTest.TxtSearch1Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.TxtSearch1.PressKeys(BusinessInsuredName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnSearch' at Center.", repo.ApplicationUnderTest.BtnSearchInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.BtnSearch.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(8));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Agent_Record_Screen.AgentRecord_Status' at Center.", repo.ApplicationUnderTest.Agent_Record_Screen.AgentRecord_StatusInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.Agent_Record_Screen.AgentRecord_Status.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(10));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnAction' at Center.", repo.ApplicationUnderTest.BtnActionInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.BtnAction.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EditQuote' at Center.", repo.ApplicationUnderTest.EditQuoteInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.EditQuote.Click();
            Delay.Milliseconds(0);
            
            MergedUserCodeMethod(repo.ApplicationUnderTest.BtnIssueInfo, repo.ApplicationUnderTest.BtnSaveInfo, lob);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 45s.", new RecordItemIndex(14));
            Delay.Duration(45000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
