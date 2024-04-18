using VAdvanceStringLibrary.Services.Internals.Objects;

namespace VAdvanceStringLibrary.Services.Internals.Conditionals
{
	internal static class Conditional
	{
		/// <summary>
		/// Performs an operation without returning anything.
		/// </summary>
		/// <param name="conditionResult">The result of a condition.</param>
		/// <param name="onTrue">The action to perform when the condition results in <see cref="bool">true</see>.</param>
		/// <param name="onFalse">The action to perform when the condition results in <see cref="bool">false</see>.</param>
		public static void Void(bool conditionResult, Action onTrue, Action? onFalse = null)
		{
			if(conditionResult)
				onTrue.Invoke();
			else if(onFalse.NotNull())
				onFalse!.Invoke();
		}

	}
}
