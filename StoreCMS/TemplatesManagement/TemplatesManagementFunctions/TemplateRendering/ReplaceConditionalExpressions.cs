﻿using System.Text;

namespace Treynessen.TemplatesManagement
{
    public static partial class TemplatesManagementFunctions
    {
        private static ConditionalExpressionInfo[] conditionalExpressions =
        {
            new ConditionalExpressionInfo{LeftSide = "[Product:IfSpecial(", RightSide=")]", Checker = "Model is ProductPage && (Model as ProductPage).SpecialProduct"},
            new ConditionalExpressionInfo{LeftSide = "[Product:IfStock(", RightSide=")]", Checker = "Model is ProductPage && (Model as ProductPage).Price > 0 && (Model as ProductPage).OldPrice > 0"}
        };

        private static void ReplaceConditionalExpressions(StringBuilder cshtmlContentBuilder)
        {
            string source = cshtmlContentBuilder.ToString();
            int beginIndex = 0;
            int endIndex = 0;
            // Ищем все условные конструкции в контенте и делаем замену
            while (beginIndex >= 0 && endIndex >= 0)
            {
                (beginIndex, endIndex) = GetNearestConditionalExpressionIndexes(source, out ConditionalExpressionInfo currentConditionalExpression);
                if (beginIndex >= 0 && endIndex > 0)
                {
                    // Получаем значение условной конструкции в скобках
                    string value = source.Substring(beginIndex + currentConditionalExpression.LeftSide.Length, endIndex - beginIndex - currentConditionalExpression.LeftSide.Length);
                    // Делаем рендер этого значения
                    string newValue = ReplaceConditionalExpressionValue(value);
                    // Заменяем
                    string conditionalExpressionInsertion = $"{currentConditionalExpression.LeftSide}{value}{currentConditionalExpression.RightSide}";
                    string conditionalExpressionReplacement = "@{ if(" + $"{currentConditionalExpression.Checker}" + ") { " + $"{newValue}" + " } }";
                    foreach (var ir in insertionReplacements)
                    {
                        if (ir.Insertion.Contains(conditionalExpressionInsertion))
                        {
                            ir.Insertion = ir.Insertion.Replace(conditionalExpressionInsertion, conditionalExpressionReplacement);
                            ir.Replacement = ir.Replacement.Replace(conditionalExpressionInsertion, conditionalExpressionReplacement);
                        }
                    }
                    cshtmlContentBuilder.Replace(conditionalExpressionInsertion, conditionalExpressionReplacement);
                    source = cshtmlContentBuilder.ToString();
                }
            }
        }
    }
}