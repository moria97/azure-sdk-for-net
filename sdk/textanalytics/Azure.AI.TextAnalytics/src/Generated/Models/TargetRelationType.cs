// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The type related to the target. </summary>
    internal readonly partial struct TargetRelationType : IEquatable<TargetRelationType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TargetRelationType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TargetRelationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AssessmentValue = "assessment";
        private const string TargetValue = "target";

        /// <summary> assessment. </summary>
        public static TargetRelationType Assessment { get; } = new TargetRelationType(AssessmentValue);
        /// <summary> target. </summary>
        public static TargetRelationType Target { get; } = new TargetRelationType(TargetValue);
        /// <summary> Determines if two <see cref="TargetRelationType"/> values are the same. </summary>
        public static bool operator ==(TargetRelationType left, TargetRelationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TargetRelationType"/> values are not the same. </summary>
        public static bool operator !=(TargetRelationType left, TargetRelationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TargetRelationType"/>. </summary>
        public static implicit operator TargetRelationType(string value) => new TargetRelationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TargetRelationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TargetRelationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
