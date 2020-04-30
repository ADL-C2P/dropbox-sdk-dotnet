// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Added pending secondary email.</para>
    /// </summary>
    public class PendingSecondaryEmailAddedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PendingSecondaryEmailAddedDetails> Encoder = new PendingSecondaryEmailAddedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PendingSecondaryEmailAddedDetails> Decoder = new PendingSecondaryEmailAddedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="PendingSecondaryEmailAddedDetails" /> class.</para>
        /// </summary>
        /// <param name="secondaryEmail">New pending secondary email.</param>
        public PendingSecondaryEmailAddedDetails(string secondaryEmail)
        {
            if (secondaryEmail == null)
            {
                throw new sys.ArgumentNullException("secondaryEmail");
            }
            if (secondaryEmail.Length > 255)
            {
                throw new sys.ArgumentOutOfRangeException("secondaryEmail", "Length should be at most 255");
            }

            this.SecondaryEmail = secondaryEmail;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="PendingSecondaryEmailAddedDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PendingSecondaryEmailAddedDetails()
        {
        }

        /// <summary>
        /// <para>New pending secondary email.</para>
        /// </summary>
        public string SecondaryEmail { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PendingSecondaryEmailAddedDetails" />.</para>
        /// </summary>
        private class PendingSecondaryEmailAddedDetailsEncoder : enc.StructEncoder<PendingSecondaryEmailAddedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PendingSecondaryEmailAddedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("secondary_email", value.SecondaryEmail, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PendingSecondaryEmailAddedDetails" />.</para>
        /// </summary>
        private class PendingSecondaryEmailAddedDetailsDecoder : enc.StructDecoder<PendingSecondaryEmailAddedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="PendingSecondaryEmailAddedDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PendingSecondaryEmailAddedDetails Create()
            {
                return new PendingSecondaryEmailAddedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PendingSecondaryEmailAddedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "secondary_email":
                        value.SecondaryEmail = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}