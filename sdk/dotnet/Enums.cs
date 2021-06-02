// *** WARNING: this file was generated by Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.Apigateway
{
    [EnumType]
    public readonly struct APIKeySource : IEquatable<APIKeySource>
    {
        private readonly string _value;

        private APIKeySource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static APIKeySource HEADER { get; } = new APIKeySource("HEADER");
        public static APIKeySource AUTHORIZER { get; } = new APIKeySource("AUTHORIZER");

        public static bool operator ==(APIKeySource left, APIKeySource right) => left.Equals(right);
        public static bool operator !=(APIKeySource left, APIKeySource right) => !left.Equals(right);

        public static explicit operator string(APIKeySource value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is APIKeySource other && Equals(other);
        public bool Equals(APIKeySource other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct Method : IEquatable<Method>
    {
        private readonly string _value;

        private Method(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static Method ANY { get; } = new Method("ANY");
        public static Method GET { get; } = new Method("GET");
        public static Method PUT { get; } = new Method("PUT");
        public static Method POST { get; } = new Method("POST");
        public static Method DELETE { get; } = new Method("DELETE");
        public static Method PATCH { get; } = new Method("PATCH");
        public static Method OPTIONS { get; } = new Method("OPTIONS");
        public static Method HEAD { get; } = new Method("HEAD");

        public static bool operator ==(Method left, Method right) => left.Equals(right);
        public static bool operator !=(Method left, Method right) => !left.Equals(right);

        public static explicit operator string(Method value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is Method other && Equals(other);
        public bool Equals(Method other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct RequestValidator : IEquatable<RequestValidator>
    {
        private readonly string _value;

        private RequestValidator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static RequestValidator ALL { get; } = new RequestValidator("ALL");
        public static RequestValidator PARAMS_ONLY { get; } = new RequestValidator("PARAMS_ONLY");
        public static RequestValidator BODY_ONLY { get; } = new RequestValidator("BODY_ONLY");

        public static bool operator ==(RequestValidator left, RequestValidator right) => left.Equals(right);
        public static bool operator !=(RequestValidator left, RequestValidator right) => !left.Equals(right);

        public static explicit operator string(RequestValidator value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is RequestValidator other && Equals(other);
        public bool Equals(RequestValidator other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}