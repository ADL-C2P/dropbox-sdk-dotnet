// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The highlight span object</para>
    /// </summary>
    public class HighlightSpan
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<HighlightSpan> Encoder = new HighlightSpanEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<HighlightSpan> Decoder = new HighlightSpanDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="HighlightSpan" /> class.</para>
        /// </summary>
        /// <param name="highlightStr">String to be determined whether it should be highlighted
        /// or not.</param>
        /// <param name="isHighlighted">The string should be highlighted or not.</param>
        public HighlightSpan(string highlightStr,
                             bool isHighlighted)
        {
            if (highlightStr == null)
            {
                throw new sys.ArgumentNullException("highlightStr");
            }

            this.HighlightStr = highlightStr;
            this.IsHighlighted = isHighlighted;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="HighlightSpan" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public HighlightSpan()
        {
        }

        /// <summary>
        /// <para>String to be determined whether it should be highlighted or not.</para>
        /// </summary>
        public string HighlightStr { get; protected set; }

        /// <summary>
        /// <para>The string should be highlighted or not.</para>
        /// </summary>
        public bool IsHighlighted { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="HighlightSpan" />.</para>
        /// </summary>
        private class HighlightSpanEncoder : enc.StructEncoder<HighlightSpan>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(HighlightSpan value, enc.IJsonWriter writer)
            {
                WriteProperty("highlight_str", value.HighlightStr, writer, enc.StringEncoder.Instance);
                WriteProperty("is_highlighted", value.IsHighlighted, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="HighlightSpan" />.</para>
        /// </summary>
        private class HighlightSpanDecoder : enc.StructDecoder<HighlightSpan>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="HighlightSpan" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override HighlightSpan Create()
            {
                return new HighlightSpan();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(HighlightSpan value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "highlight_str":
                        value.HighlightStr = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "is_highlighted":
                        value.IsHighlighted = enc.BooleanDecoder.Instance.Decode(reader);
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
