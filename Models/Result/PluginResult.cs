using System;
using System.Collections.Generic;
using System.Linq;

namespace HubTo.Abstraction.Models.PluginResult
{
    public class PluginResult
    {
        public bool IsSuccess { get; }
        public IReadOnlyList<string> Errors { get; }
        public object Data { get; }

        protected PluginResult(bool success, IEnumerable<string> errors = null, object data = null)
        {
            IsSuccess = success;
            Errors = errors != null ? errors.ToArray() : Array.Empty<string>();
            Data = data;
        }

        public static PluginResult Ok() => new PluginResult(true);

        public static PluginResult Fail(string error)
            => new PluginResult(false, new[] { error });

        public static PluginResult Fail(IEnumerable<string> errors)
            => new PluginResult(false, errors);

        public static PluginResult Fail(IEnumerable<string> errors, object data)
            => new PluginResult(false, errors, data);

        public static PluginResult<T> Ok<T>(T value)
            => PluginResult<T>.Ok(value);

        public static PluginResult<T> Fail<T>(params string[] errors)
            => PluginResult<T>.Fail(errors);
    }

    public sealed class PluginResult<T> : PluginResult
    {
        public T Value { get; }

        private PluginResult(T value)
            : base(true, null, value)
        {
            Value = value;
        }

        private PluginResult(IEnumerable<string> errors, object data = null)
            : base(false, errors, data)
        {
            Value = default(T);
        }

        public static PluginResult<T> Ok(T value)
            => new PluginResult<T>(value);

        public new static PluginResult<T> Fail(params string[] errors)
            => new PluginResult<T>(errors);

        public new static PluginResult<T> Fail(IEnumerable<string> errors, object data = null)
            => new PluginResult<T>(errors, data);
    }
}
