using System.Diagnostics.CodeAnalysis;

namespace Tavstal.PayPalSDK.Http;

/// <summary>
/// Represents the outcome of an operation that can either succeed with a value
/// of type <typeparamref name="T"/> or fail with an error of type <typeparamref name="TError"/>.
/// </summary>
/// <typeparam name="T">The type of the success value.</typeparam>
/// <typeparam name="TError">The type of the error value.</typeparam>
public sealed class Result<T, TError>
{
    /// <summary>
    /// Gets a value indicating whether the operation completed successfully.
    /// </summary>
    [MemberNotNullWhen(true, nameof(Value))]
    [MemberNotNullWhen(false, nameof(Error))]
    public bool IsSuccess { get; }

    /// <summary>
    /// Gets a value indicating whether the operation failed.
    /// </summary>
    [MemberNotNullWhen(false, nameof(Value))]
    [MemberNotNullWhen(true, nameof(Error))]
    public bool IsError => !IsSuccess;

    /// <summary>
    /// Gets the success value when <see cref="IsSuccess"/> is <c>true</c>.
    /// </summary>
    /// <remarks>
    /// Prefer <see cref="Match"/>/<see cref="Switch"/> for safety.
    /// </remarks>
    public T? Value { get; }

    /// <summary>
    /// Gets the error value when <see cref="IsError"/> is <c>true</c>.
    /// </summary>
    /// <remarks>
    /// Prefer <see cref="Match"/>/<see cref="Switch"/> for safety.
    /// </remarks>
    public TError? Error { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Result{T, TError}"/> class.
    /// Use <see cref="Success"/> or <see cref="Failure"/> to create instances.
    /// </summary>
    /// <param name="isSuccess">Indicates whether the result is successful.</param>
    /// <param name="value">The success value.</param>
    /// <param name="error">The error value.</param>
    private Result(bool isSuccess, T? value, TError? error)
    {
        IsSuccess = isSuccess;
        Value = value;
        Error = error;
    }

    /// <summary>
    /// Executes one of the provided functions depending on the result state,
    /// and returns the result.
    /// </summary>
    /// <param name="onSuccess">Function to execute when <see cref="IsSuccess"/> is <c>true</c>.</param>
    /// <param name="onFailure">Function to execute when <see cref="IsError"/> is <c>true</c>.</param>
    /// <typeparam name="TResult">The return type of both functions.</typeparam>
    /// <returns>The value returned by whichever function was executed.</returns>
    public TResult Match<TResult>(Func<T, TResult> onSuccess, Func<TError, TResult> onFailure)
        => IsSuccess ? onSuccess(Value) : onFailure(Error);
    
    /// <summary>
    /// Executes one of the provided actions depending on the result state.
    /// </summary>
    /// <param name="onSuccess">Action to execute when <see cref="IsSuccess"/> is <c>true</c>.</param>
    /// <param name="onFailure">Action to execute when <see cref="IsError"/> is <c>true</c>.</param>
    public void Switch(Action<T> onSuccess, Action<TError> onFailure)
    {
         if (IsSuccess) 
             onSuccess(Value);
         else 
             onFailure(Error);
    }

    /// <summary>
    /// Creates a successful result containing the provided value.
    /// </summary>
    /// <param name="value">The success value.</param>
    /// <returns>A successful <see cref="Result{T, TError}"/> instance.</returns>
    public static Result<T, TError> Success(T value)
        => new(true, value, default);

    /// <summary>
    /// Creates a failed result containing the provided error.
    /// </summary>
    /// <param name="error">The error value.</param>
    /// <returns>A failed <see cref="Result{T, TError}"/> instance.</returns>
    public static Result<T, TError> Failure(TError error)
        => new(false, default, error);
}