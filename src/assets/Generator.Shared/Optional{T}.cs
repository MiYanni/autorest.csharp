// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

#nullable enable

namespace Azure.Core
{
    public struct Optional<T>
    {
        private readonly T _value;

        public Optional(T value)
        {
            _value = value;
            // HasValue is always set to true, even if value is null
            HasValue = true;
        }

        public T Value
        {
            get
            {
                if (!HasValue)
                {
                    throw new InvalidOperationException("No value has been assigned.");
                }

                return _value;
            }
        }

        // HasValue will only be false when using default parameter-less constructor
        public bool HasValue { get; }

        public static implicit operator Optional<T>(T value)
        {
            return new Optional<T>(value);
        }

        public static explicit operator T(Optional<T> value)
        {
            return value.Value;
        }
    }
}
