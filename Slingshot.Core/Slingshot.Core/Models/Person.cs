﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Slingshot.Core.Model
{
    public class Person : IImportModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the family identifier.
        /// </summary>
        /// <value>
        /// The family identifier.
        /// </value>
        public int? FamilyId { get; set; }

        /// <summary>
        /// Gets or sets the name of the family.
        /// </summary>
        /// <value>
        /// The name of the family.
        /// </value>
        public string FamilyName { get; set; }

        /// <summary>
        /// Gets or sets the family image URL.
        /// </summary>
        /// <value>
        /// The family image URL.
        /// </value>
        public string FamilyImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the family role.
        /// </summary>
        /// <value>
        /// The family role.
        /// </value>
        public FamilyRole FamilyRole { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the name of the nick.
        /// </summary>
        /// <value>
        /// The name of the nick.
        /// </value>
        public string NickName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the name of the middle.
        /// </summary>
        /// <value>
        /// The name of the middle.
        /// </value>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the salutation.
        /// </summary>
        /// <value>
        /// The salutation.
        /// </value>
        public string Salutation { get; set; }

        /// <summary>
        /// Gets or sets the suffix.
        /// </summary>
        /// <value>
        /// The suffix.
        /// </value>
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the marital status.
        /// </summary>
        /// <value>
        /// The marital status.
        /// </value>
        public MaritalStatus MaritalStatus { get; set; }

        /// <summary>
        /// Gets or sets the birthdate.
        /// Magic Year of 9999
        /// </summary>
        /// <value>
        /// The birthdate.
        /// </value>
        public DateTime? Birthdate { get; set; }

        /// <summary>
        /// Set the BirthDate.Year to this if only Month and Day are specified
        /// </summary>
        public readonly int BirthdateNoYearMagicYear = 9999;

        /// <summary>
        /// Gets or sets the anniversay.
        /// </summary>
        /// <value>
        /// The anniversay.
        /// </value>
        public DateTime? AnniversaryDate { get; set; }

        /// <summary>
        /// Gets or sets the record status.
        /// </summary>
        /// <value>
        /// The record status.
        /// </value>
        public RecordStatus RecordStatus { get; set; }

        /// <summary>
        /// Gets or sets the inactive reason.
        /// </summary>
        /// <value>
        /// The inactive reason.
        /// </value>
        public string InactiveReason { get; set; }

        /// <summary>
        /// Gets or sets the connection status.
        /// </summary>
        /// <value>
        /// The connection status.
        /// </value>
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// Gets or sets the email preference.
        /// </summary>
        /// <value>
        /// The email preference.
        /// </value>
        public EmailPreference EmailPreference { get; set; }

        /// <summary>
        /// Gets or sets the created date time.
        /// </summary>
        /// <value>
        /// The created date time.
        /// </value>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the modified date time.
        /// </summary>
        /// <value>
        /// The modified date time.
        /// </value>
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the person photo URL.
        /// </summary>
        /// <value>
        /// The person photo URL.
        /// </value>
        public string PersonPhotoUrl { get; set; }

        /// <summary>
        /// Gets or sets the campus.
        /// </summary>
        /// <value>
        /// The campus.
        /// </value>
        public Campus Campus { get; set; } = new Campus();

        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        /// <value>
        /// The note.
        /// </value>
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets the grade.
        /// </summary>
        /// <value>
        /// The grade.
        /// </value>
        public string Grade { get; set; }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public List<PersonAttributeValue> Attributes { get; set; } = new List<PersonAttributeValue>();

        /// <summary>
        /// Gets or sets the phone numbers.
        /// </summary>
        /// <value>
        /// The phone numbers.
        /// </value>
        public List<PersonPhone> PhoneNumbers { get; set; } = new List<PersonPhone>();

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        /// <value>
        /// The addresses.
        /// </value>
        public List<PersonAddress> Addresses { get; set; } = new List<PersonAddress>();

        /// <summary>
        /// Gets or sets the give individually.
        /// </summary>
        /// <value>
        /// The give individually.
        /// </value>
        public bool? GiveIndividually { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is deceased.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is deceased; otherwise, <c>false</c>.
        /// </value>
        public bool IsDeceased { get; set; }

        public string GetFileName()
        {
            return "person.csv";
        }
    }

    public enum EmailPreference
    {
        EmailAllowed,
        NoMassEmails,
        DoNotEmail
    }

public enum FamilyRole
    {
        Adult,
        Child
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public enum MaritalStatus
    {
        Married,
        Divorced,
        Single,
        Unknown
    }

    public enum RecordStatus
    {
        Active,
        Inactive,
        Pending
    }
}
