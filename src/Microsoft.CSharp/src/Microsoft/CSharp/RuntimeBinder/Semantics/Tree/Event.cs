// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
    internal sealed class ExprEvent : Expr, IExprWithObject
    {
        public Expr OptionalObject { get; set; }

        public EventWithType EventWithType { get; set; }

        public override ExpressionKind Kind => ExpressionKind.EK_EVENT;
    }
}
