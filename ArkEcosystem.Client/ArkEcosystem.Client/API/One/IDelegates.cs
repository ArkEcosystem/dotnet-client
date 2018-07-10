// Author:
//       Brian Faust <brian@ark.io>
//
// Copyright (c) 2018 Ark Ecosystem <info@ark.io>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ArkEcosystem.Client.Helpers;
using Newtonsoft.Json.Linq;

namespace ArkEcosystem.Client.API.One
{
    public interface IDelegates
    {
        JObject All(Dictionary<string, string> parameters = null);
        Task<JObject> AllAsync(Dictionary<string, string> parameters = null);

        JObject Show(Dictionary<string, string> parameters = null);
        Task<JObject> ShowAsync(Dictionary<string, string> parameters = null);

        JObject Count();
        Task<JObject> CountAsync();

        JObject Fee();
        Task<JObject> FeeAsync();

        JObject ForgedByAccount(string generatorPublicKey);
        Task<JObject> ForgedByAccountAsync(string generatorPublicKey);

        JObject Search(string query);
        Task<JObject> SearchAsync(string query);

        JObject Voters(string publicKey);
        Task<JObject> VotersAsync(string publicKey);

        JObject NextForgers();
        Task<JObject> NextForgersAsync();
    }
}
