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

namespace Sid_FCGAProject
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UW_ModifyOwnerDetails recording.
    /// </summary>
    [TestModule("64679ed9-b137-4e3f-831a-003a527b475c", ModuleType.Recording, 1)]
    public partial class UW_ModifyOwnerDetails : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static UW_ModifyOwnerDetails instance = new UW_ModifyOwnerDetails();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UW_ModifyOwnerDetails()
        {
            UW_FirstName = "S";
            UW_LastName = "M";
            UW_OwnerPercent = "100";
            UW_Ownerstate = "florida";
            Status_Reason = "UW Modify Owner Details";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UW_ModifyOwnerDetails Instance
        {
            get { return instance; }
        }

#region Variables

        string _UW_FirstName;

        /// <summary>
        /// Gets or sets the value of variable UW_FirstName.
        /// </summary>
        [TestVariable("3cef02e3-c83f-42a5-aa29-50efc4758a61")]
        public string UW_FirstName
        {
            get { return _UW_FirstName; }
            set { _UW_FirstName = value; }
        }

        string _UW_LastName;

        /// <summary>
        /// Gets or sets the value of variable UW_LastName.
        /// </summary>
        [TestVariable("266fbf99-6412-462a-be52-06b1f19a3577")]
        public string UW_LastName
        {
            get { return _UW_LastName; }
            set { _UW_LastName = value; }
        }

        string _UW_OwnerPercent;

        /// <summary>
        /// Gets or sets the value of variable UW_OwnerPercent.
        /// </summary>
        [TestVariable("5394e627-8047-40f8-8bb4-29b2cd2591e5")]
        public string UW_OwnerPercent
        {
            get { return _UW_OwnerPercent; }
            set { _UW_OwnerPercent = value; }
        }

        string _UW_Ownerstate;

        /// <summary>
        /// Gets or sets the value of variable UW_Ownerstate.
        /// </summary>
        [TestVariable("45600740-0a58-4744-bcc6-892b1df8ea66")]
        public string UW_Ownerstate
        {
            get { return _UW_Ownerstate; }
            set { _UW_Ownerstate = value; }
        }

        string _Status_Reason;

        /// <summary>
        /// Gets or sets the value of variable Status_Reason.
        /// </summary>
        [TestVariable("b2cef47b-d692-497c-95cc-5f2da4a072f0")]
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$UW_FirstName' on item 'ApplicationUnderTest.TxtFirstName1'.", repo.ApplicationUnderTest.TxtFirstName1Info, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TxtFirstName1.Element.SetAttributeValue("Value", UW_FirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$UW_LastName' on item 'ApplicationUnderTest.TxtLastName1'.", repo.ApplicationUnderTest.TxtLastName1Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TxtLastName1.Element.SetAttributeValue("Value", UW_LastName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$UW_OwnerPercent' on item 'ApplicationUnderTest.TxtPerOwner1'.", repo.ApplicationUnderTest.TxtPerOwner1Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TxtPerOwner1.Element.SetAttributeValue("Value", UW_OwnerPercent);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OwnerStateSelection' at Center.", repo.ApplicationUnderTest.OwnerStateSelectionInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.OwnerStateSelection.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UW_Ownerstate' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Search.PressKeys(UW_Ownerstate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Search.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
