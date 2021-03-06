#pragma warning disable SA1028 // Code must not contain trailing whitespace
/*
 * Meetup Management Service API
 *
 * Meetup Management Service API
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
#pragma warning restore SA1028 // Code must not contain trailing whitespace

// ReSharper disable RedundantUsingDirective
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DotNetRu.MeetupManagement.WebApi.Contract.Models
#pragma warning disable SA1028 // Code must not contain trailing whitespace
{ 
    /// <inheritdoc />
    /// <summary>
    /// 
    /// </summary>
#pragma warning restore SA1028 // Code must not contain trailing whitespace
    [DataContract]
    public class TalkDraft : IEquatable<TalkDraft>
#pragma warning disable SA1028 // Code must not contain trailing whitespace
    {
#pragma warning restore SA1028 // Code must not contain trailing whitespace
        /// <summary>
        /// Gets or sets Id
        /// </summary>
        [Required]
        [DataMember(Name="Id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Title
        /// </summary>
        [Required]
        [DataMember(Name="Title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Description
        /// </summary>
        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets TalkRehearsals
        /// </summary>
        [DataMember(Name="TalkRehearsals")]
        public Collection<TalkRehearsalReference> TalkRehearsals { get; set; }

        /// <summary>
        /// Gets or sets MeetupDraft
        /// </summary>
        [DataMember(Name="MeetupDraft")]
        public MeetupReference MeetupDraft { get; set; }

        /// <summary>
        /// Gets or sets Speakers
        /// </summary>
        [DataMember(Name="Speakers")]
        public Collection<SpeakerReference> Speakers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TalkDraft {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TalkRehearsals: ").Append(TalkRehearsals).Append("\n");
            sb.Append("  MeetupDraft: ").Append(MeetupDraft).Append("\n");
            sb.Append("  Speakers: ").Append(Speakers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        // ReSharper disable once UnusedMember.Global
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
#pragma warning disable IDE0041 // Use 'is null' check
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            return obj.GetType() == GetType() && Equals((TalkDraft)obj);
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns true if TalkDraft instances are equal
        /// </summary>
        /// <param name="other">Instance of TalkDraft to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TalkDraft other)
        {
#pragma warning disable IDE0041 // Use 'is null' check
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

#pragma warning disable CA1309 // Use ordinal stringcomparison
#pragma warning disable CA1307 // Specify StringComparison
#pragma warning disable SA1515 // Single-line comment must be preceded by blank line
#pragma warning disable SA1009 // Closing parenthesis must be spaced correctly
            return
#pragma warning disable SA1119 // Statement must not use unnecessary parenthesis
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(Id, other.Id) ||
                    (Id != null && Id.Equals(other.Id))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(Title, other.Title) ||
                    (Title != null && Title.Equals(other.Title))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(Description, other.Description) ||
                    (Description != null && Description.Equals(other.Description))
                ) &&
                (
                    TalkRehearsals == other.TalkRehearsals ||
                    (TalkRehearsals != null && TalkRehearsals.SequenceEqual(other.TalkRehearsals))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(MeetupDraft, other.MeetupDraft) ||
                    (MeetupDraft != null && MeetupDraft.Equals(other.MeetupDraft))
                ) &&
                (
                    Speakers == other.Speakers ||
                    (Speakers != null && Speakers.SequenceEqual(other.Speakers))
                );
#pragma warning restore SA1119 // Statement must not use unnecessary parenthesis
#pragma warning restore SA1009 // Closing parenthesis must be spaced correctly
#pragma warning restore SA1515 // Single-line comment must be preceded by blank line
#pragma warning restore CA1307 // Specify StringComparison
#pragma warning restore CA1309 // Use ordinal stringcomparison
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // Overflow is fine, just wrap
            unchecked
            {
                var hashCode = 41;

                // Suitable nullity checks etc, of course :)
#pragma warning disable CA1307 // Specify StringComparison

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Id != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + Id.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Title != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + Title.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Description != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + Description.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (TalkRehearsals != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + TalkRehearsals.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (MeetupDraft != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + MeetupDraft.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Speakers != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + Speakers.GetHashCode();
                    }
#pragma warning restore CA1307 // Specify StringComparison
                return hashCode;
            }
        }

#pragma warning disable SA1124 // Do not use regions
        #region Operators
        #pragma warning disable 1591
        #pragma warning disable SA1201 // Elements must appear in the correct order
        public static bool operator ==(TalkDraft left, TalkDraft right)
        {
            return Equals(left, right);
        }
        #pragma warning restore SA1201 // Elements must appear in the correct order

        public static bool operator !=(TalkDraft left, TalkDraft right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
#pragma warning restore SA1124 // Do not use regions
    }
}
