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

namespace Sid_FCGAProject.GL_Product
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CG2037FormsDetails recording.
    /// </summary>
    [TestModule("3f612e3e-ddd5-41e6-9b7b-0c6ac03fcc1d", ModuleType.Recording, 1)]
    public partial class CG2037FormsDetails : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static CG2037FormsDetails instance = new CG2037FormsDetails();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CG2037FormsDetails()
        {
            CG2037_CompanyName = "CG2037";
            CG2037_Address1 = "Address1";
            CG2037_Address2 = "address2";
            CG2037_City = "Tampa";
            CG2037_ZipCode = "33604";
            CG2037No = "2";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CG2037FormsDetails Instance
        {
            get { return instance; }
        }

#region Variables

        string _CG2037_CompanyName;

        /// <summary>
        /// Gets or sets the value of variable CG2037_CompanyName.
        /// </summary>
        [TestVariable("057f4e33-c4d9-49c7-93b4-e1265f667202")]
        public string CG2037_CompanyName
        {
            get { return _CG2037_CompanyName; }
            set { _CG2037_CompanyName = value; }
        }

        string _CG2037_Address1;

        /// <summary>
        /// Gets or sets the value of variable CG2037_Address1.
        /// </summary>
        [TestVariable("0aa2dcf8-1f9e-438d-a806-4c10b98ad2ec")]
        public string CG2037_Address1
        {
            get { return _CG2037_Address1; }
            set { _CG2037_Address1 = value; }
        }

        string _CG2037_Address2;

        /// <summary>
        /// Gets or sets the value of variable CG2037_Address2.
        /// </summary>
        [TestVariable("912fedff-ad30-4942-bbb6-290846c0af41")]
        public string CG2037_Address2
        {
            get { return _CG2037_Address2; }
            set { _CG2037_Address2 = value; }
        }

        string _CG2037_City;

        /// <summary>
        /// Gets or sets the value of variable CG2037_City.
        /// </summary>
        [TestVariable("53c45758-5687-4a41-bc2e-4a4950f3db73")]
        public string CG2037_City
        {
            get { return _CG2037_City; }
            set { _CG2037_City = value; }
        }

        string _CG2037_ZipCode;

        /// <summary>
        /// Gets or sets the value of variable CG2037_ZipCode.
        /// </summary>
        [TestVariable("dd466c64-932d-4580-b791-e56c18e30b8a")]
        public string CG2037_ZipCode
        {
            get { return _CG2037_ZipCode; }
            set { _CG2037_ZipCode = value; }
        }

        string _CG2037No;

        /// <summary>
        /// Gets or sets the value of variable CG2037No.
        /// </summary>
        [TestVariable("470bc600-24af-44ae-9b7b-5dff10e4a8df")]
        public string CG2037No
        {
            get { return _CG2037No; }
            set { _CG2037No = value; }
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

            CG2037FormDetailsUserCodeMethod(repo.ApplicationUnderTest.TxtCompanyNameCG2037Info, repo.ApplicationUnderTest.TxtAddress1CG2037Info, repo.ApplicationUnderTest.TxtAddress2CG2037Info, repo.ApplicationUnderTest.TxtCityCG2037Info, repo.ApplicationUnderTest.TxtZipCodeCG2037Info, repo.ApplicationUnderTest.TxtCompanyNameCG20371Info, repo.ApplicationUnderTest.TxtAddress1CG20371Info, repo.ApplicationUnderTest.TxtAddress2CG20371Info, repo.ApplicationUnderTest.TxtCityCG20371Info, repo.ApplicationUnderTest.TxtZipCodeCG20371Info, repo.ApplicationUnderTest.TxtCompanyNameCG20372Info, repo.ApplicationUnderTest.TxtAddress1CG20372Info, repo.ApplicationUnderTest.TxtAddress2CG20372Info, repo.ApplicationUnderTest.TxtCityCG20372Info, repo.ApplicationUnderTest.TxtZipCodeCG20372Info, CG2037No);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
