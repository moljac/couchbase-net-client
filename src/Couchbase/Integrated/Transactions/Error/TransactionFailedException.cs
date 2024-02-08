#if NET5_0_OR_GREATER
#nullable enable
using System;

namespace Couchbase.Integrated.Transactions.Error
{
    /// <summary>
    /// A generic exception thrown internally that indicates that a transaction failed.
    /// </summary>
    internal class TransactionFailedException : CouchbaseException
    {
        /// <summary>
        /// Gets the final result of the transaction.
        /// </summary>
        public TransactionResult? Result { get; }

        /// <inheritdoc />
        public TransactionFailedException(string message, Exception innerException, TransactionResult? result) : base(message, innerException)
        {
            Result = result;
        }
    }
}


/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2021 Couchbase, Inc.
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
#endif
