﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slingshot.Core.Model;
using Slingshot.Core.Utilities;

namespace Slingshot.F1.Utilities
{
    public abstract class F1Translator
    {
        protected static int loopThreshold = 100000000;
        protected static List<int> AccountIds;
        protected static List<FamilyMember> familyMembers = new List<FamilyMember>();

        /// <summary>
        ///  Set F1Api.DumpResponseToXmlFile to true to save all API Responses
        ///   to XML files and include them in the slingshot package
        /// </summary>
        /// <value>
        /// <c>true</c> if the response should get dumped to XML; otherwise, <c>false</c>.
        /// </value>
        public static bool DumpResponseToXmlFile { get; set; }

        /// <summary>
        /// Gets or sets the last run date.
        /// </summary>
        /// <value>
        /// The last run date.
        /// </value>
        public static DateTime LastRunDate { get; set; } = DateTime.MinValue;

        /// <summary>
        /// Gets a value indicating whether this instance is connected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is connected; otherwise, <c>false</c>.
        /// </value>
        public static bool IsConnected { get; protected set; } = false;

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        public static string ErrorMessage { get; set; }

        /// <summary>
        /// Initializes the export.
        /// </summary>
        public static void InitializeExport()
        {
            ImportPackage.InitalizePackageFolder();
        }



        public abstract void ExportIndividuals( DateTime modifiedSince, int peoplePerPage = 500 );

        public abstract void ExportFinancialAccounts();

        public abstract void ExportFinancialPledges();

        public abstract void ExportFinancialBatches( DateTime modifiedSince );

        public abstract void ExportAttendance( DateTime modifiedSince );

        public abstract void ExportContributions( DateTime modifiedSince, bool exportContribImages );

        public abstract void ExportGroups( List<int> selectedGroupTypes );

        public abstract List<PersonAttribute> WritePersonAttributes();

        public abstract List<GroupType> GetGroupTypes();

        public abstract void WriteGroupTypes( List<int> selectedGroupTypes );

        public abstract List<FamilyMember> GetFamilyMembers();
    }

    /// <summary>
    /// The Family Member.
    ///
    /// Used to determine head of household and household campus.
    /// </summary>
    public class FamilyMember
    {
        public int HouseholdId { get; set; }

        public int PersonId { get; set; }

        public int FamilyRoleId { get; set; }

        public string HouseholdCampusName { get; set; }

        public int? HouseholdCampusId { get; set; }
    }
}