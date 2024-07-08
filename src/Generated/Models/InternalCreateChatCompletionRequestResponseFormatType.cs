// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Chat
{
    internal readonly partial struct InternalCreateChatCompletionRequestResponseFormatType : IEquatable<InternalCreateChatCompletionRequestResponseFormatType>
    {
        private readonly string _value;

        public InternalCreateChatCompletionRequestResponseFormatType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextValue = "text";
        private const string JsonObjectValue = "json_object";

        public static InternalCreateChatCompletionRequestResponseFormatType Text { get; } = new InternalCreateChatCompletionRequestResponseFormatType(TextValue);
        public static InternalCreateChatCompletionRequestResponseFormatType JsonObject { get; } = new InternalCreateChatCompletionRequestResponseFormatType(JsonObjectValue);
        public static bool operator ==(InternalCreateChatCompletionRequestResponseFormatType left, InternalCreateChatCompletionRequestResponseFormatType right) => left.Equals(right);
        public static bool operator !=(InternalCreateChatCompletionRequestResponseFormatType left, InternalCreateChatCompletionRequestResponseFormatType right) => !left.Equals(right);
        public static implicit operator InternalCreateChatCompletionRequestResponseFormatType(string value) => new InternalCreateChatCompletionRequestResponseFormatType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateChatCompletionRequestResponseFormatType other && Equals(other);
        public bool Equals(InternalCreateChatCompletionRequestResponseFormatType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}
