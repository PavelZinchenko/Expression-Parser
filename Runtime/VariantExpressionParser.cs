using System;

namespace CodeWriter.ExpressionParser
{
    public class VariantExpressionParser : ExpressionParser<Variant>
    {
        public static readonly ExpressionParser<Variant> Instance = new VariantExpressionParser();

        protected override Variant False { get; } = Variant.False;
        protected override Variant True { get; } = Variant.True;

        protected override Variant Parse(string input) => Variant.Parse(input);

        protected override Variant Negate(Variant v) => -v;
        protected override Variant Add(Variant a, Variant b) => a + b;
        protected override Variant Sub(Variant a, Variant b) => a - b;
        protected override Variant Mul(Variant a, Variant b) => a * b;
        protected override Variant Div(Variant a, Variant b) => a / b;
        protected override Variant Mod(Variant a, Variant b) => a % b;
        protected override Variant Pow(Variant a, Variant b) => throw new NotImplementedException();
        protected override Variant Equal(Variant a, Variant b) => a == b;
        protected override Variant NotEqual(Variant a, Variant b) => a != b ? 1 : 0;
        protected override Variant LessThan(Variant a, Variant b) => a < b ? 1 : 0;
        protected override Variant LessThanOrEqual(Variant a, Variant b) => a <= b ? 1 : 0;
        protected override Variant GreaterThan(Variant a, Variant b) => a > b ? Variant.True : Variant.False;
        protected override Variant GreaterThanOrEqual(Variant a, Variant b) => a >= b ? Variant.True : Variant.False;
        protected override bool IsTrue(Variant v) => v.AsBool;
        protected override Variant Round(Variant v) => Variant.Round(v);
        protected override Variant Ceiling(Variant v) => Variant.Ceil(v);
        protected override Variant Floor(Variant v) => Variant.Floor(v);
        protected override Variant Log10(Variant v) => throw new NotImplementedException();

        protected override Variant Log(Variant v, Variant newBase) => throw new NotImplementedException();
    }
}
