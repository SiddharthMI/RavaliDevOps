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

namespace Sid_FCGAProject.Outdated_Class_Spe_Script
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Class_Specific_Question_91155 recording.
    /// </summary>
    [TestModule("e815cc02-54aa-43a6-bbcf-0e33fc5564d0", ModuleType.Recording, 1)]
    public partial class Class_Specific_Question_91155 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static Class_Specific_Question_91155 instance = new Class_Specific_Question_91155();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Class_Specific_Question_91155()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Class_Specific_Question_91155 Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite' at 73;25.", repo.FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhiteInfo, new RecordItemIndex(0));
            repo.FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite.Click("73;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite1' at 67;21.", repo.FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite1Info, new RecordItemIndex(1));
            repo.FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite1.Click("67;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite5' at 68;21.", repo.FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite5Info, new RecordItemIndex(2));
            repo.FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite5.Click("68;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite6' at 63;25.", repo.FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite6Info, new RecordItemIndex(3));
            repo.FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite6.Click("63;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite7' at 66;26.", repo.FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite7Info, new RecordItemIndex(4));
            repo.FCGAGLAnd1MorePageWorkMicro.PgBody.RadioBorderWhite7.Click("66;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FCGAGLAnd1MorePageWorkMicro.PgBody.BtnSave' at 96;20.", repo.FCGAGLAnd1MorePageWorkMicro.PgBody.BtnSaveInfo, new RecordItemIndex(5));
            repo.FCGAGLAnd1MorePageWorkMicro.PgBody.BtnSave.Click("96;20");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
