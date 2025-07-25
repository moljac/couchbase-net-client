using System;
using Couchbase.Core.IO.Converters;

namespace Couchbase.Core.IO.Operations.Errors
{
    internal sealed class GetErrorMap : OperationBase<ErrorMapDto>
    {
        private const int DefaultVersion = 2; // will be configurable at some point

        public ErrorMap ErrorMap { get; set; }

        protected override void WriteKey(OperationBuilder builder)
        {
        }

        protected override void WriteExtras(OperationBuilder builder)
        {
        }

        protected override void WriteBody(OperationBuilder builder)
        {
            var body = builder.GetSpan(sizeof(ushort));
            ByteConverter.FromInt16(DefaultVersion, body);
            builder.Advance(sizeof(ushort));
        }

        protected override void ReadExtras(ReadOnlySpan<byte> buffer)
        {
            TryReadServerDuration(buffer);
        }

        public override OpCode OpCode => OpCode.GetErrorMap;
    }
}

#region [ License information          ]

/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2017 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/

#endregion
