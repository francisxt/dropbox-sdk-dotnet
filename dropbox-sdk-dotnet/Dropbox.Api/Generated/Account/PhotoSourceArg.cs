// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Account
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The photo source arg object</para>
    /// </summary>
    public class PhotoSourceArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PhotoSourceArg> Encoder = new PhotoSourceArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PhotoSourceArg> Decoder = new PhotoSourceArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PhotoSourceArg" /> class.</para>
        /// </summary>
        public PhotoSourceArg()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Base64Data</para>
        /// </summary>
        public bool IsBase64Data
        {
            get
            {
                return this is Base64Data;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Base64Data, or <c>null</c>.</para>
        /// </summary>
        public Base64Data AsBase64Data
        {
            get
            {
                return this as Base64Data;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PhotoSourceArg" />.</para>
        /// </summary>
        private class PhotoSourceArgEncoder : enc.StructEncoder<PhotoSourceArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PhotoSourceArg value, enc.IJsonWriter writer)
            {
                if (value is Base64Data)
                {
                    WriteProperty(".tag", "base64_data", writer, enc.StringEncoder.Instance);
                    Base64Data.Encoder.EncodeFields((Base64Data)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PhotoSourceArg" />.</para>
        /// </summary>
        private class PhotoSourceArgDecoder : enc.UnionDecoder<PhotoSourceArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PhotoSourceArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PhotoSourceArg Create()
            {
                return new PhotoSourceArg();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override PhotoSourceArg Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "base64_data":
                        return Base64Data.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Image data in base64-encoded bytes.</para>
        /// </summary>
        public sealed class Base64Data : PhotoSourceArg
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Base64Data> Encoder = new Base64DataEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Base64Data> Decoder = new Base64DataDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Base64Data" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Base64Data(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Base64Data" /> class.</para>
            /// </summary>
            private Base64Data()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Base64Data" />.</para>
            /// </summary>
            private class Base64DataEncoder : enc.StructEncoder<Base64Data>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Base64Data value, enc.IJsonWriter writer)
                {
                    WriteProperty("base64_data", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Base64Data" />.</para>
            /// </summary>
            private class Base64DataDecoder : enc.StructDecoder<Base64Data>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Base64Data" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Base64Data Create()
                {
                    return new Base64Data();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(Base64Data value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "base64_data":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : PhotoSourceArg
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}