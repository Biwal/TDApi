﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Uwp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for UwpClient.
    /// </summary>
    public static partial class UwpClientExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Film> GetFilms(this IUwpClient operations)
            {
                return Task.Factory.StartNew(s => ((IUwpClient)s).GetFilmsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Film>> GetFilmsAsync(this IUwpClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFilmsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static Film PostFilm(this IUwpClient operations, Film body = default(Film))
            {
                return Task.Factory.StartNew(s => ((IUwpClient)s).PostFilmAsync(body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Film> PostFilmAsync(this IUwpClient operations, Film body = default(Film), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostFilmWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Film GetFilm(this IUwpClient operations, int id)
            {
                return Task.Factory.StartNew(s => ((IUwpClient)s).GetFilmAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Film> GetFilmAsync(this IUwpClient operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFilmWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void PutFilm(this IUwpClient operations, int id, Film body = default(Film))
            {
                Task.Factory.StartNew(s => ((IUwpClient)s).PutFilmAsync(id, body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutFilmAsync(this IUwpClient operations, int id, Film body = default(Film), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutFilmWithHttpMessagesAsync(id, body, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Film DeleteFilm(this IUwpClient operations, int id)
            {
                return Task.Factory.StartNew(s => ((IUwpClient)s).DeleteFilmAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Film> DeleteFilmAsync(this IUwpClient operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteFilmWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Genre> GetGenres(this IUwpClient operations)
            {
                return Task.Factory.StartNew(s => ((IUwpClient)s).GetGenresAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Genre>> GetGenresAsync(this IUwpClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGenresWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static Genre PostGenre(this IUwpClient operations, Genre body = default(Genre))
            {
                return Task.Factory.StartNew(s => ((IUwpClient)s).PostGenreAsync(body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Genre> PostGenreAsync(this IUwpClient operations, Genre body = default(Genre), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostGenreWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Genre GetGenre(this IUwpClient operations, int id)
            {
                return Task.Factory.StartNew(s => ((IUwpClient)s).GetGenreAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Genre> GetGenreAsync(this IUwpClient operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGenreWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void PutGenre(this IUwpClient operations, int id, Genre body = default(Genre))
            {
                Task.Factory.StartNew(s => ((IUwpClient)s).PutGenreAsync(id, body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutGenreAsync(this IUwpClient operations, int id, Genre body = default(Genre), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutGenreWithHttpMessagesAsync(id, body, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Genre DeleteGenre(this IUwpClient operations, int id)
            {
                return Task.Factory.StartNew(s => ((IUwpClient)s).DeleteGenreAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Genre> DeleteGenreAsync(this IUwpClient operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteGenreWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void Authenticate(this IUwpClient operations, AuthenticateModel body = default(AuthenticateModel))
            {
                Task.Factory.StartNew(s => ((IUwpClient)s).AuthenticateAsync(body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AuthenticateAsync(this IUwpClient operations, AuthenticateModel body = default(AuthenticateModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.AuthenticateWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
