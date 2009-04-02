/*
 * Copyright (C) 2007, Dave Watson <dwatson@mimvista.com>
 * Copyright (C) 2008, Robin Rosenberg <robin.rosenberg@dewire.com>
 * Copyright (C) 2008, Shawn O. Pearce <spearce@spearce.org>
 * Copyright (C) 2008, Kevin Thompson <kevin.thompson@theautomaters.com>
 *
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or
 * without modification, are permitted provided that the following
 * conditions are met:
 *
 * - Redistributions of source code must retain the above copyright
 *   notice, this list of conditions and the following disclaimer.
 *
 * - Redistributions in binary form must reproduce the above
 *   copyright notice, this list of conditions and the following
 *   disclaimer in the documentation and/or other materials provided
 *   with the distribution.
 *
 * - Neither the name of the Git Development Community nor the
 *   names of its contributors may be used to endorse or promote
 *   products derived from this software without specific prior
 *   written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND
 * CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES,
 * INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
 * NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
 * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
 * ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */
using System.Globalization;
using System.Text;

namespace Gitty.Core
{
        public static class Constants {
		/// <summary>
		///   Prefix for branch refs
		/// </summary>
		public static readonly string HeadsPrefix = "refs/heads";

		/// <summary>
		///   Prefix for remote refs
		/// </summary>
		public static readonly string RemotesPrefix = "refs/remotes";

		/// <summary>
		///   Special name for the "HEAD" symbolic ref
		/// </summary>
		public static readonly string Head = "HEAD";

		public static readonly string Master = "master";

		/// <summary>
		///    Text string that identifies an object as an annotated tag.
		/// <summary>
		/// <remarks>
		///   Annotated tags store a pointer to any other object, and an additional
		///   message. It is most commonly used to record a stable release of the
		///   project.
		/// </remarks>
		public static readonly string TypeTag = "tag";

		/// <summary>
		///    Text string that identifies an object as tree.
		/// <summary>
		/// <remarks>
 		/// Trees attach object ids (hashes) to names and file
		/// modes. The normal use for a tree is to store a
		/// version of a directory and its contents.
		/// </remarks>
		public static readonly string TypeTree = "tree";

		/// <summary>
		///    Text string that identifies an object as a blob
		/// <summary>
		/// <remarks>
		/// Blobs store whole file revisions. They are used
		/// for any user file, as well as for symlinks. Blobs
		/// form the bulk of any project's storage space.
		/// </remarks>
		public static readonly string TypeBlob = "blob";

		/// <summary>
		///    Text string that identifies an object as a commit.
		/// <summary>
		/// <remarks>
		/// Commits connect trees into a string of project
		/// histories, where each commit is an assertion that
		/// the best way to continue is to use this other tree
		/// (set of files).
		/// </remarks>
		public static readonly string TypeCommit = "commit";
 
		public static readonly Encoding Encoding = Encoding.UTF8;

		public static readonly string RefsSlash = "refs/";

		public static readonly string TagsPrefix = "refs/tags";
		
		public static readonly string TagsSlash = TagsPrefix + "/";

		public static readonly string HeadsSlash = HeadsPrefix + "/";

		public static readonly string[] RefSearchPaths = { "", RefsSlash, TagsSlash, HeadsSlash, RemotesPrefix + "/" };
		
		public static readonly byte [] EncodedTypeCommit = new byte [] { (byte) 'c', (byte) 'o', (byte) 'm', (byte) 'm', (byte) 'i', (byte) 't' };
		public static readonly byte [] EncodedTypeTree   = new byte [] { (byte) 't', (byte) 'r', (byte) 'e', (byte) 'e' };
		public static readonly byte [] EncodedTypeBlob   = new byte [] { (byte) 'b', (byte) 'l', (byte) 'o', (byte) 'b' };
		public static readonly byte [] EncodedTypeTag    = new byte [] { (byte) 't', (byte) 'a', (byte) 'g' };

	}
}