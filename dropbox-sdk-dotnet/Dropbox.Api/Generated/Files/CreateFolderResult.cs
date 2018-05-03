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
    /// <para>The create folder result object</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Files.FileOpsResult" />
    public class CreateFolderResult : FileOpsResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<CreateFolderResult> Encoder = new CreateFolderResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<CreateFolderResult> Decoder = new CreateFolderResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CreateFolderResult" />
        /// class.</para>
        /// </summary>
        /// <param name="metadata">Metadata of the created folder.</param>
        public CreateFolderResult(FolderMetadata metadata)
        {
            if (metadata == null)
            {
                throw new sys.ArgumentNullException("metadata");
            }

            this.Metadata = metadata;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CreateFolderResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public CreateFolderResult()
        {
        }

        /// <summary>
        /// <para>Metadata of the created folder.</para>
        /// </summary>
        public FolderMetadata Metadata { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="CreateFolderResult" />.</para>
        /// </summary>
        private class CreateFolderResultEncoder : enc.StructEncoder<CreateFolderResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(CreateFolderResult value, enc.IJsonWriter writer)
            {
                WriteProperty("metadata", value.Metadata, writer, global::Dropbox.Api.Files.FolderMetadata.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="CreateFolderResult" />.</para>
        /// </summary>
        private class CreateFolderResultDecoder : enc.StructDecoder<CreateFolderResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="CreateFolderResult" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override CreateFolderResult Create()
            {
                return new CreateFolderResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(CreateFolderResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "metadata":
                        value.Metadata = global::Dropbox.Api.Files.FolderMetadata.Decoder.Decode(reader);
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