// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace CassandraSharp.ObjectMapper
{
    public enum CqlType
    {
        Auto,

        // US-ASCII character string
        Ascii,

        // 64-bit signed long
        BigInt,

        // Arbitrary bytes (no validation), expressed as hexadecimal
        Blob,

        // true or false
        Boolean,

        // Distributed counter value (64-bit long)
        Counter,

        // Variable-precision decimal
        Decimal,

        // 64-bit IEEE-754 floating point
        Double,

        // 32-bit IEEE-754 floating point
        Float,

        // 32-bit signed integer
        Int,

        // UTF-8 encoded string
        Text,

        // Date plus time, encoded as 8 bytes since epoch
        Timestamp,

        // Type 1 or type 4 UUID
        Uuid,

        // UTF-8 encoded string
        Varchar,

        // Arbitrary-precision integer
        Varint,
    }
}