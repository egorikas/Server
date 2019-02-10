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
    public class MeetupDraft : IEquatable<MeetupDraft>
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
        /// Gets or sets Name
        /// </summary>
        [Required]
        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Venue
        /// </summary>
        [DataMember(Name="Venue")]
        public VenueReference Venue { get; set; }

        /// <summary>
        /// Gets or sets TalkDrafts
        /// </summary>
        [DataMember(Name="TalkDrafts")]
        public Collection<TalkReference> TalkDrafts { get; set; }

        /// <summary>
        /// Gets or sets Friends
        /// </summary>
        [DataMember(Name="Friends")]
        public Collection<FriendReference> Friends { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeetupDraft {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  TalkDrafts: ").Append(TalkDrafts).Append("\n");
            sb.Append("  Friends: ").Append(Friends).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MeetupDraft)obj);
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns true if MeetupDraft instances are equal
        /// </summary>
        /// <param name="other">Instance of MeetupDraft to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeetupDraft other)
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
                    string.Equals(Name, other.Name) ||
                    (Name != null && Name.Equals(other.Name))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(Venue, other.Venue) ||
                    (Venue != null && Venue.Equals(other.Venue))
                ) &&
                (
                    TalkDrafts == other.TalkDrafts ||
                    (TalkDrafts != null && TalkDrafts.SequenceEqual(other.TalkDrafts))
                ) &&
                (
                    Friends == other.Friends ||
                    (Friends != null && Friends.SequenceEqual(other.Friends))
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
                    if (Name != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + Name.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Venue != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + Venue.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (TalkDrafts != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + TalkDrafts.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Friends != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + Friends.GetHashCode();
                    }
#pragma warning restore CA1307 // Specify StringComparison
                return hashCode;
            }
        }

#pragma warning disable SA1124 // Do not use regions
        #region Operators
        #pragma warning disable 1591
        #pragma warning disable SA1201 // Elements must appear in the correct order
        public static bool operator ==(MeetupDraft left, MeetupDraft right)
        {
            return Equals(left, right);
        }
        #pragma warning restore SA1201 // Elements must appear in the correct order

        public static bool operator !=(MeetupDraft left, MeetupDraft right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
#pragma warning restore SA1124 // Do not use regions
    }
}
