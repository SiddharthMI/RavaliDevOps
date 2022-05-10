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
    ///The GL_AplicationPage_P2 recording.
    /// </summary>
    [TestModule("54be0649-547b-4331-af6f-f9430363ed90", ModuleType.Recording, 1)]
    public partial class GL_AplicationPage_P2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static GL_AplicationPage_P2 instance = new GL_AplicationPage_P2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GL_AplicationPage_P2()
        {
            GL_LicenseType = "Permanent";
            GL_LicenseNo = "78575876";
            GL_IndustrialPercent = "100";
            GL_NewConstructionPercent = "100";
            GL_CommercialPercent = "0";
            GL_ResidentialPercent = "0";
            GL_RoomAdditionsPercent = "0";
            GL_RemodelingPercent = "0";
            GL_RepairOrServicePercent = "0";
            GL_WorkSubContractedComment = "OK";
            GL_ExpectedGross = "456781";
            GL_AmountInsSubContractor = "32456";
            GL_AmtUninsuredSubContractor = "0";
            GL_PartnersFullTimeEmp = "12";
            GL_PartnersPartTimeEmp = "0";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GL_AplicationPage_P2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _GL_LicenseType;

        /// <summary>
        /// Gets or sets the value of variable GL_LicenseType.
        /// </summary>
        [TestVariable("78d72dce-2445-4eed-8fc5-533c0ea0851b")]
        public string GL_LicenseType
        {
            get { return _GL_LicenseType; }
            set { _GL_LicenseType = value; }
        }

        string _GL_LicenseNo;

        /// <summary>
        /// Gets or sets the value of variable GL_LicenseNo.
        /// </summary>
        [TestVariable("9b979df7-edc0-4e9a-be31-ba04ba2ff281")]
        public string GL_LicenseNo
        {
            get { return _GL_LicenseNo; }
            set { _GL_LicenseNo = value; }
        }

        string _GL_IndustrialPercent;

        /// <summary>
        /// Gets or sets the value of variable GL_IndustrialPercent.
        /// </summary>
        [TestVariable("6bd527d0-330f-4d10-b19f-cc93414e28cf")]
        public string GL_IndustrialPercent
        {
            get { return _GL_IndustrialPercent; }
            set { _GL_IndustrialPercent = value; }
        }

        string _GL_NewConstructionPercent;

        /// <summary>
        /// Gets or sets the value of variable GL_NewConstructionPercent.
        /// </summary>
        [TestVariable("60931f24-7296-4c05-84a7-1f1d61f53250")]
        public string GL_NewConstructionPercent
        {
            get { return _GL_NewConstructionPercent; }
            set { _GL_NewConstructionPercent = value; }
        }

        string _GL_CommercialPercent;

        /// <summary>
        /// Gets or sets the value of variable GL_CommercialPercent.
        /// </summary>
        [TestVariable("1e79dc34-808e-4df5-bf87-4676de5b5f75")]
        public string GL_CommercialPercent
        {
            get { return _GL_CommercialPercent; }
            set { _GL_CommercialPercent = value; }
        }

        string _GL_ResidentialPercent;

        /// <summary>
        /// Gets or sets the value of variable GL_ResidentialPercent.
        /// </summary>
        [TestVariable("a273660d-6441-4dd9-98f6-bba221902053")]
        public string GL_ResidentialPercent
        {
            get { return _GL_ResidentialPercent; }
            set { _GL_ResidentialPercent = value; }
        }

        string _GL_RoomAdditionsPercent;

        /// <summary>
        /// Gets or sets the value of variable GL_RoomAdditionsPercent.
        /// </summary>
        [TestVariable("ab1fa37c-2b06-404f-bfa2-7861674479b0")]
        public string GL_RoomAdditionsPercent
        {
            get { return _GL_RoomAdditionsPercent; }
            set { _GL_RoomAdditionsPercent = value; }
        }

        string _GL_RemodelingPercent;

        /// <summary>
        /// Gets or sets the value of variable GL_RemodelingPercent.
        /// </summary>
        [TestVariable("642b8aa4-36c6-493c-8382-3c2dd2772393")]
        public string GL_RemodelingPercent
        {
            get { return _GL_RemodelingPercent; }
            set { _GL_RemodelingPercent = value; }
        }

        string _GL_RepairOrServicePercent;

        /// <summary>
        /// Gets or sets the value of variable GL_RepairOrServicePercent.
        /// </summary>
        [TestVariable("2e6a11c4-426e-499c-80ce-69198272014d")]
        public string GL_RepairOrServicePercent
        {
            get { return _GL_RepairOrServicePercent; }
            set { _GL_RepairOrServicePercent = value; }
        }

        string _GL_WorkSubContractedComment;

        /// <summary>
        /// Gets or sets the value of variable GL_WorkSubContractedComment.
        /// </summary>
        [TestVariable("3635eec7-038e-4a05-8d0a-eab02e5cfc76")]
        public string GL_WorkSubContractedComment
        {
            get { return _GL_WorkSubContractedComment; }
            set { _GL_WorkSubContractedComment = value; }
        }

        string _GL_ExpectedGross;

        /// <summary>
        /// Gets or sets the value of variable GL_ExpectedGross.
        /// </summary>
        [TestVariable("49c56ebf-d5a0-40db-a207-d35a4f31447a")]
        public string GL_ExpectedGross
        {
            get { return _GL_ExpectedGross; }
            set { _GL_ExpectedGross = value; }
        }

        string _GL_AmountInsSubContractor;

        /// <summary>
        /// Gets or sets the value of variable GL_AmountInsSubContractor.
        /// </summary>
        [TestVariable("48d5c790-1f21-4a09-aaff-7fca4402834b")]
        public string GL_AmountInsSubContractor
        {
            get { return _GL_AmountInsSubContractor; }
            set { _GL_AmountInsSubContractor = value; }
        }

        string _GL_AmtUninsuredSubContractor;

        /// <summary>
        /// Gets or sets the value of variable GL_AmtUninsuredSubContractor.
        /// </summary>
        [TestVariable("a2053f29-a5af-4b70-a3dc-81e1a848e58b")]
        public string GL_AmtUninsuredSubContractor
        {
            get { return _GL_AmtUninsuredSubContractor; }
            set { _GL_AmtUninsuredSubContractor = value; }
        }

        string _GL_PartnersFullTimeEmp;

        /// <summary>
        /// Gets or sets the value of variable GL_PartnersFullTimeEmp.
        /// </summary>
        [TestVariable("55d28b6d-5612-4a09-8d0c-94563a84704f")]
        public string GL_PartnersFullTimeEmp
        {
            get { return _GL_PartnersFullTimeEmp; }
            set { _GL_PartnersFullTimeEmp = value; }
        }

        string _GL_PartnersPartTimeEmp;

        /// <summary>
        /// Gets or sets the value of variable GL_PartnersPartTimeEmp.
        /// </summary>
        [TestVariable("8236713c-8830-4bbd-8c3c-e68f33ed79c5")]
        public string GL_PartnersPartTimeEmp
        {
            get { return _GL_PartnersPartTimeEmp; }
            set { _GL_PartnersPartTimeEmp = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtLicenseType' at Center.", repo.ApplicationUnderTest.TxtLicenseTypeInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TxtLicenseType.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtLicenseType'.", repo.ApplicationUnderTest.TxtLicenseTypeInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TxtLicenseType.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_LicenseType' with focus on 'ApplicationUnderTest.TxtLicenseType'.", repo.ApplicationUnderTest.TxtLicenseTypeInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TxtLicenseType.PressKeys(GL_LicenseType);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtLicenseNumber' at Center.", repo.ApplicationUnderTest.TxtLicenseNumberInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.TxtLicenseNumber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtLicenseNumber'.", repo.ApplicationUnderTest.TxtLicenseNumberInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.TxtLicenseNumber.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_LicenseNo' with focus on 'ApplicationUnderTest.TxtLicenseNumber'.", repo.ApplicationUnderTest.TxtLicenseNumberInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TxtLicenseNumber.PressKeys(GL_LicenseNo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LabelTag_Yes6' at Center.", repo.ApplicationUnderTest.LabelTag_Yes6Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.LabelTag_Yes6.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtIndustrial' at Center.", repo.ApplicationUnderTest.TxtIndustrialInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.TxtIndustrial.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtIndustrial'.", repo.ApplicationUnderTest.TxtIndustrialInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.TxtIndustrial.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_IndustrialPercent' with focus on 'ApplicationUnderTest.TxtIndustrial'.", repo.ApplicationUnderTest.TxtIndustrialInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.TxtIndustrial.PressKeys(GL_IndustrialPercent);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtNewConstruction' at Center.", repo.ApplicationUnderTest.TxtNewConstructionInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.TxtNewConstruction.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtNewConstruction'.", repo.ApplicationUnderTest.TxtNewConstructionInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.TxtNewConstruction.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_NewConstructionPercent' with focus on 'ApplicationUnderTest.TxtNewConstruction'.", repo.ApplicationUnderTest.TxtNewConstructionInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.TxtNewConstruction.PressKeys(GL_NewConstructionPercent);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtCommercial' at Center.", repo.ApplicationUnderTest.TxtCommercialInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.TxtCommercial.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtCommercial'.", repo.ApplicationUnderTest.TxtCommercialInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.TxtCommercial.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_CommercialPercent' with focus on 'ApplicationUnderTest.TxtCommercial'.", repo.ApplicationUnderTest.TxtCommercialInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.TxtCommercial.PressKeys(GL_CommercialPercent);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtResidential' at Center.", repo.ApplicationUnderTest.TxtResidentialInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.TxtResidential.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtResidential'.", repo.ApplicationUnderTest.TxtResidentialInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.TxtResidential.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_ResidentialPercent' with focus on 'ApplicationUnderTest.TxtResidential'.", repo.ApplicationUnderTest.TxtResidentialInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.TxtResidential.PressKeys(GL_ResidentialPercent);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtRoomAdditions' at Center.", repo.ApplicationUnderTest.TxtRoomAdditionsInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.TxtRoomAdditions.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtRoomAdditions'.", repo.ApplicationUnderTest.TxtRoomAdditionsInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.TxtRoomAdditions.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_RoomAdditionsPercent' with focus on 'ApplicationUnderTest.TxtRoomAdditions'.", repo.ApplicationUnderTest.TxtRoomAdditionsInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.TxtRoomAdditions.PressKeys(GL_RoomAdditionsPercent);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtRemodeling' at Center.", repo.ApplicationUnderTest.TxtRemodelingInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.TxtRemodeling.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtRemodeling'.", repo.ApplicationUnderTest.TxtRemodelingInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.TxtRemodeling.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_RemodelingPercent' with focus on 'ApplicationUnderTest.TxtRemodeling'.", repo.ApplicationUnderTest.TxtRemodelingInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.TxtRemodeling.PressKeys(GL_RemodelingPercent);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtRepaireOrService' at Center.", repo.ApplicationUnderTest.TxtRepaireOrServiceInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.TxtRepaireOrService.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtRepaireOrService'.", repo.ApplicationUnderTest.TxtRepaireOrServiceInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.TxtRepaireOrService.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_RepairOrServicePercent' with focus on 'ApplicationUnderTest.TxtRepaireOrService'.", repo.ApplicationUnderTest.TxtRepaireOrServiceInfo, new RecordItemIndex(27));
            repo.ApplicationUnderTest.TxtRepaireOrService.PressKeys(GL_RepairOrServicePercent);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LabelTag_Yes7' at Center.", repo.ApplicationUnderTest.LabelTag_Yes7Info, new RecordItemIndex(28));
            repo.ApplicationUnderTest.LabelTag_Yes7.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtWorkSubcontracted' at Center.", repo.ApplicationUnderTest.TxtWorkSubcontractedInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.TxtWorkSubcontracted.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtWorkSubcontracted'.", repo.ApplicationUnderTest.TxtWorkSubcontractedInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.TxtWorkSubcontracted.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_WorkSubContractedComment' with focus on 'ApplicationUnderTest.TxtWorkSubcontracted'.", repo.ApplicationUnderTest.TxtWorkSubcontractedInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.TxtWorkSubcontracted.PressKeys(GL_WorkSubContractedComment);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LabelTag_Yes8' at Center.", repo.ApplicationUnderTest.LabelTag_Yes8Info, new RecordItemIndex(32));
            repo.ApplicationUnderTest.LabelTag_Yes8.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LabelTag_Yes9' at Center.", repo.ApplicationUnderTest.LabelTag_Yes9Info, new RecordItemIndex(33));
            repo.ApplicationUnderTest.LabelTag_Yes9.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtExpectedGrossReceipts' at Center.", repo.ApplicationUnderTest.TxtExpectedGrossReceiptsInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.TxtExpectedGrossReceipts.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtExpectedGrossReceipts'.", repo.ApplicationUnderTest.TxtExpectedGrossReceiptsInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.TxtExpectedGrossReceipts.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_ExpectedGross' with focus on 'ApplicationUnderTest.TxtExpectedGrossReceipts'.", repo.ApplicationUnderTest.TxtExpectedGrossReceiptsInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.TxtExpectedGrossReceipts.PressKeys(GL_ExpectedGross);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtAmountInsuredSubcon' at Center.", repo.ApplicationUnderTest.TxtAmountInsuredSubconInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.TxtAmountInsuredSubcon.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtAmountInsuredSubcon'.", repo.ApplicationUnderTest.TxtAmountInsuredSubconInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.TxtAmountInsuredSubcon.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_AmountInsSubContractor' with focus on 'ApplicationUnderTest.TxtAmountInsuredSubcon'.", repo.ApplicationUnderTest.TxtAmountInsuredSubconInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.TxtAmountInsuredSubcon.PressKeys(GL_AmountInsSubContractor);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtAmountUninsuredSubcon' at Center.", repo.ApplicationUnderTest.TxtAmountUninsuredSubconInfo, new RecordItemIndex(40));
            repo.ApplicationUnderTest.TxtAmountUninsuredSubcon.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtAmountUninsuredSubcon'.", repo.ApplicationUnderTest.TxtAmountUninsuredSubconInfo, new RecordItemIndex(41));
            repo.ApplicationUnderTest.TxtAmountUninsuredSubcon.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_AmtUninsuredSubContractor' with focus on 'ApplicationUnderTest.TxtAmountUninsuredSubcon'.", repo.ApplicationUnderTest.TxtAmountUninsuredSubconInfo, new RecordItemIndex(42));
            repo.ApplicationUnderTest.TxtAmountUninsuredSubcon.PressKeys(GL_AmtUninsuredSubContractor);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtPartnersFullTimeEmp' at Center.", repo.ApplicationUnderTest.TxtPartnersFullTimeEmpInfo, new RecordItemIndex(43));
            repo.ApplicationUnderTest.TxtPartnersFullTimeEmp.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtPartnersFullTimeEmp'.", repo.ApplicationUnderTest.TxtPartnersFullTimeEmpInfo, new RecordItemIndex(44));
            repo.ApplicationUnderTest.TxtPartnersFullTimeEmp.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_PartnersFullTimeEmp' with focus on 'ApplicationUnderTest.TxtPartnersFullTimeEmp'.", repo.ApplicationUnderTest.TxtPartnersFullTimeEmpInfo, new RecordItemIndex(45));
            repo.ApplicationUnderTest.TxtPartnersFullTimeEmp.PressKeys(GL_PartnersFullTimeEmp);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtPartnersPartTimeEmp' at Center.", repo.ApplicationUnderTest.TxtPartnersPartTimeEmpInfo, new RecordItemIndex(46));
            repo.ApplicationUnderTest.TxtPartnersPartTimeEmp.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtPartnersPartTimeEmp'.", repo.ApplicationUnderTest.TxtPartnersPartTimeEmpInfo, new RecordItemIndex(47));
            repo.ApplicationUnderTest.TxtPartnersPartTimeEmp.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GL_PartnersPartTimeEmp' with focus on 'ApplicationUnderTest.TxtPartnersPartTimeEmp'.", repo.ApplicationUnderTest.TxtPartnersPartTimeEmpInfo, new RecordItemIndex(48));
            repo.ApplicationUnderTest.TxtPartnersPartTimeEmp.PressKeys(GL_PartnersPartTimeEmp);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IAgree' at Center.", repo.IAgreeInfo, new RecordItemIndex(49));
            repo.IAgree.Click();
            Delay.Milliseconds(0);
            
            // Application Docs
            Report.Log(ReportLevel.Info, "Section", "Application Docs", new RecordItemIndex(50));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnPrintSubmit' at Center.", repo.ApplicationUnderTest.BtnPrintSubmitInfo, new RecordItemIndex(51));
            //repo.ApplicationUnderTest.BtnPrintSubmit.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(52));
            //Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentPage' at Center.", repo.ApplicationUnderTest.DocumentPageInfo, new RecordItemIndex(53));
            //repo.ApplicationUnderTest.DocumentPage.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsQawinstonFwcinsComFWCPortalP.Close3' at Center.", repo.HttpsQawinstonFwcinsComFWCPortalP.Close3Info, new RecordItemIndex(54));
            //repo.HttpsQawinstonFwcinsComFWCPortalP.Close3.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Section", "", new RecordItemIndex(55));
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(56));
            //Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnPaymentIssue' at Center.", repo.ApplicationUnderTest.BtnPaymentIssueInfo, new RecordItemIndex(57));
            repo.ApplicationUnderTest.BtnPaymentIssue.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1.3m to exist. Associated repository item: 'ApplicationUnderTest.Labelcheckbox'", repo.ApplicationUnderTest.LabelcheckboxInfo, new ActionTimeout(80000), new RecordItemIndex(58));
            repo.ApplicationUnderTest.LabelcheckboxInfo.WaitForExists(80000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 25s.", new RecordItemIndex(59));
            Delay.Duration(25000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
