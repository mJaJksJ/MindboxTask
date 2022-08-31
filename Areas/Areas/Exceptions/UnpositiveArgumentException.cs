namespace Areas.Exceptions
{
    /// <summary>
    /// Ошибка неположительного значения
    /// </summary>
    public class UnpositiveArgumentException : ArgumentException
    {
        /// <inheritdoc/>
        public override string Message => "Lines of triangle must be positive numbers";
    }
}
