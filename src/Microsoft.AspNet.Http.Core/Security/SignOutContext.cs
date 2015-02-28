// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.AspNet.Http.Interfaces.Security;

namespace Microsoft.AspNet.Http.Core.Security
{
    public class SignOutContext : ISignOutContext
    {
        private List<string> _accepted;

        public SignOutContext([NotNull] IEnumerable<string> authenticationSchemes)
        {
            AuthenticationSchemes = authenticationSchemes;
            _accepted = new List<string>();
        }

        public IEnumerable<string> AuthenticationSchemes { get; private set; }

        public IEnumerable<string> Accepted
        {
            get { return _accepted; }
        }

        public void Accept(string authenticationType, IDictionary<string, object> description)
        {
            _accepted.Add(authenticationType);
        }
    }
}
