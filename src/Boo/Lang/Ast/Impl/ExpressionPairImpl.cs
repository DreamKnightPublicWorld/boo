﻿#region license
// boo - an extensible programming language for the CLI
// Copyright (C) 2004 Rodrigo B. de Oliveira
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// As a special exception, if you link this library with other files to
// produce an executable, this library does not by itself cause the
// resulting executable to be covered by the GNU General Public License.
// This exception does not however invalidate any other reasons why the
// executable file might be covered by the GNU General Public License.
//
// Contact Information
//
// mailto:rbo@acm.org
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by
// astgenerator.boo on 3/3/2004 11:15:05 AM
//

namespace Boo.Lang.Ast.Impl
{
	using System;
	using Boo.Lang.Ast;
	
	[Serializable]
	public abstract class ExpressionPairImpl : Node
	{

		protected Expression _first;
		protected Expression _second;

		protected ExpressionPairImpl()
		{
			InitializeFields();
		}
		
		protected ExpressionPairImpl(LexicalInfo info) : base(info)
		{
			InitializeFields();
		}
		

		protected ExpressionPairImpl(Expression first, Expression second)
		{
			InitializeFields();
			First = first;
			Second = second;
		}
			
		protected ExpressionPairImpl(LexicalInfo lexicalInfo, Expression first, Expression second) : base(lexicalInfo)
		{
			InitializeFields();
			First = first;
			Second = second;
		}
			
		new public Boo.Lang.Ast.ExpressionPair CloneNode()
		{
			return Clone() as Boo.Lang.Ast.ExpressionPair;
		}

		override public NodeType NodeType
		{
			get
			{
				return NodeType.ExpressionPair;
			}
		}
		
		override public void Switch(IAstTransformer transformer, out Node resultingNode)
		{
			Boo.Lang.Ast.ExpressionPair thisNode = (Boo.Lang.Ast.ExpressionPair)this;
			Boo.Lang.Ast.ExpressionPair resultingTypedNode = thisNode;
			transformer.OnExpressionPair(thisNode, ref resultingTypedNode);
			resultingNode = resultingTypedNode;
		}

		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}

			if (_first == existing)
			{
				this.First = ((Boo.Lang.Ast.Expression)newNode);
				return true;
			}

			if (_second == existing)
			{
				this.Second = ((Boo.Lang.Ast.Expression)newNode);
				return true;
			}

			return false;
		}

		override public object Clone()
		{
			Boo.Lang.Ast.ExpressionPair clone = (Boo.Lang.Ast.ExpressionPair)System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Boo.Lang.Ast.ExpressionPair));
			clone._lexicalInfo = _lexicalInfo;
			clone._documentation = _documentation;
			clone._properties = (System.Collections.Hashtable)_properties.Clone();
			

			if (null != _first)
			{
				clone._first = ((Expression)_first.Clone());
				clone._first.InitializeParent(clone);
			}

			if (null != _second)
			{
				clone._second = ((Expression)_second.Clone());
				clone._second.InitializeParent(clone);
			}
			
			return clone;
		}
			
		public Expression First
		{
			get
			{
				return _first;
			}
			

			set
			{
				if (_first != value)
				{
					_first = value;
					if (null != _first)
					{
						_first.InitializeParent(this);

					}
				}
			}
			

		}
		

		public Expression Second
		{
			get
			{
				return _second;
			}
			

			set
			{
				if (_second != value)
				{
					_second = value;
					if (null != _second)
					{
						_second.InitializeParent(this);

					}
				}
			}
			

		}
		

		private void InitializeFields()
		{

		}
	}
}
