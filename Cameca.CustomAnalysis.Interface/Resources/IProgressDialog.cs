using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IProgressDialog
{
	Task ShowDialog(string? message, Func<Task> action);
	Task ShowDialog(string? message, Func<IProgress<double>, Task> action);
	Task ShowDialog(string? message, Func<CancellationToken, Task> action);
	Task ShowDialog(string? message, Func<IProgress<double>, CancellationToken, Task> action);

	Task<T> ShowDialog<T>(string? message, Func<Task<T>> action);
	Task<T> ShowDialog<T>(string? message, Func<IProgress<double>, Task<T>> action);
	Task<T> ShowDialog<T>(string? message, Func<CancellationToken, Task<T>> action);
	Task<T> ShowDialog<T>(string? message, Func<IProgress<double>, CancellationToken, Task<T>> action);
}
