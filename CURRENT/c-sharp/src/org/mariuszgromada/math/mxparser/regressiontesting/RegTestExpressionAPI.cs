/*
 * @(#)RegTestExpressionAPI.cs        4.1.0    2017-04-22
 *
 * You may use this software under the condition of "Simplified BSD License"
 *
 * Copyright 2010-2017 MARIUSZ GROMADA. All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification, are
 * permitted provided that the following conditions are met:
 *
 *    1. Redistributions of source code must retain the above copyright notice, this list of
 *       conditions and the following disclaimer.
 *
 *    2. Redistributions in binary form must reproduce the above copyright notice, this list
 *       of conditions and the following disclaimer in the documentation and/or other materials
 *       provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY <MARIUSZ GROMADA> ``AS IS'' AND ANY EXPRESS OR IMPLIED
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
 * FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
 * ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
 * ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 * The views and conclusions contained in the software and documentation are those of the
 * authors and should not be interpreted as representing official policies, either expressed
 * or implied, of MARIUSZ GROMADA.
 *
 * If you have any questions/bugs feel free to contact:
 *
 *     Mariusz Gromada
 *     mariuszgromada.org@gmail.com
 *     http://mathparser.org
 *     http://mathspace.pl
 *     http://janetsudoku.mariuszgromada.org
 *     http://github.com/mariuszgromada/MathParser.org-mXparser
 *     http://mariuszgromada.github.io/MathParser.org-mXparser
 *     http://mxparser.sourceforge.net
 *     http://bitbucket.org/mariuszgromada/mxparser
 *     http://mxparser.codeplex.com
 *     http://github.com/mariuszgromada/Janet-Sudoku
 *     http://janetsudoku.codeplex.com
 *     http://sourceforge.net/projects/janetsudoku
 *     http://bitbucket.org/mariuszgromada/janet-sudoku
 *     http://github.com/mariuszgromada/MathParser.org-mXparser
 *
 *                              Asked if he believes in one God, a mathematician answered:
 *                              "Yes, up to isomorphism."
 */
using org.mariuszgromada.math.mxparser.parsertokens;
using System;
using System.Collections.Generic;

namespace org.mariuszgromada.math.mxparser.regressiontesting
{
	/**
	 * RegTestExpressionAPI - regression tests for the expression API
	 *
	 * @author         <b>Mariusz Gromada</b><br>
	 *                 <a href="mailto:mariuszgromada.org@gmail.com">mariuszgromada.org@gmail.com</a><br>
	 *                 <a href="http://mathspace.pl" target="_blank">MathSpace.pl</a><br>
	 *                 <a href="http://mathparser.org" target="_blank">MathParser.org - mXparser project page</a><br>
	 *                 <a href="http://github.com/mariuszgromada/MathParser.org-mXparser" target="_blank">mXparser on GitHub</a><br>
	 *                 <a href="http://mxparser.sourceforge.net" target="_blank">mXparser on SourceForge</a><br>
	 *                 <a href="http://bitbucket.org/mariuszgromada/mxparser" target="_blank">mXparser on Bitbucket</a><br>
	 *                 <a href="http://mxparser.codeplex.com" target="_blank">mXparser on CodePlex</a><br>
	 *                 <a href="http://janetsudoku.mariuszgromada.org" target="_blank">Janet Sudoku - project web page</a><br>
	 *                 <a href="http://github.com/mariuszgromada/Janet-Sudoku" target="_blank">Janet Sudoku on GitHub</a><br>
	 *                 <a href="http://janetsudoku.codeplex.com" target="_blank">Janet Sudoku on CodePlex</a><br>
	 *                 <a href="http://sourceforge.net/projects/janetsudoku" target="_blank">Janet Sudoku on SourceForge</a><br>
	 *                 <a href="http://bitbucket.org/mariuszgromada/janet-sudoku" target="_blank">Janet Sudoku on BitBucket</a><br>
	 *
	 * @version        4.1.0
	 *
	 * @see Expression
	 */
	[CLSCompliant(true)]
	public class RegTestExpressionAPI {
		/**
		 * Runs API regression tests.
		 *
		 * @return Number of tests with error result.
		 */
		public static int Start() {
			long start = mXparser.currentTimeMillis();
			bool syn1, syn2, syn3, syn4, syn5, syn6, syn7, syn8, b1, b2, b3;
			String s1, s2;
			int i1, i2, n1, n2, n3, n4, n5, n6;
			Argument A1, A2, A3, A4, A5;
			Function F1, F2, F3, F4, F5;
			Constant C1, C2, C3, C4, C5;
			double d1, d2, d3;
			Constant c1 = new Constant("c1",1);
			Constant c2 = new Constant("c2",2);
			Constant c3 = new Constant("c3",3);
			//Constant c4 = new Constant("c4",4);
			Constant c5 = new Constant("c5",5);
			Constant c6 = new Constant("c6",6);
			Function f1 = new Function("f1","1","x");
			Function f2 = new Function("f2","2","x");
			Function f3 = new Function("f3","3","x");
			Function f4 = new Function("f4","4","x");
			//Function f5 = new Function("f5","5","x");
			Function f6 = new Function("f6","6","x");
			Function f7 = new Function("f7","7","x");
			Argument a1 = new Argument("a1",1);
			Argument a2 = new Argument("a2",2);
			Argument a3 = new Argument("a3",3);
			Argument a4 = new Argument("a4",4);
			Argument a5 = new Argument("a5",5);
			Argument a6 = new Argument("a6",6);
			Argument a7 = new Argument("a7",7);
			//Argument a8 = new Argument("a8",8);
			bool[] test = new bool[100];
			for (int i = 0; i < 100; i++)
				test[i] = false;
			Expression e;
			int testId = -1;
			/*
			 * 0. public Expression()
			 */
			testId++;
			e = new Expression();
			if (	e.getExpressionString().Equals("")
					&& e.getArgumentsNumber() == 0
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 0	)
				test[testId] = true;
			/*
			 * 1.
			 */
			testId++;
			e = new Expression("a1+c2", a1, a2, a3, a4, a5);
			if (	e.getExpressionString().Equals("a1+c2")
					&& e.getArgumentsNumber() == 5
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 0	)
				test[testId] = true;
			/*
			 * 2.
			 */
			testId++;
			e = new Expression("a1+c2", a1, f1, a2, f2, a3, a4, f3, a5, f4);
			if (	e.getExpressionString().Equals("a1+c2")
					&& e.getArgumentsNumber() == 5
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 4	)
				test[testId] = true;
			/*
			 * 3
			 */
			testId++;
			e = new Expression("a1+c2", a1, a2, c1, c2, a3, a4, c5, a5, f1, f2, f3, f4);
			if (	e.getExpressionString().Equals("a1+c2")
					&& e.getArgumentsNumber() == 5
					&& e.getConstantsNumber() == 3
					&& e.getFunctionsNumber() == 4	)
				test[testId] = true;
			/*
			 * 4. void setExpressionString(String expressionString), String getExpressionString(), void clearExpressionString()
			 */
			testId++;
			syn1 = e.checkSyntax();
			e.setExpressionString("c2+a1");
			syn2 = e.getSyntaxStatus();
			syn3 = e.checkSyntax();
			s1 = e.getExpressionString();
			syn4 = e.getSyntaxStatus();
			syn5 = e.checkSyntax();
			e.clearExpressionString();
			syn6 = e.getSyntaxStatus();
			syn7 = e.checkSyntax();
			s2 = e.getExpressionString();
			syn8 = e.getSyntaxStatus();
			if (	s1.Equals("c2+a1")
					&& s2.Equals("")
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.NO_SYNTAX_ERRORS
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					&& syn6 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn7 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn8 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					)
				test[testId] = true;
			/*
			 * 5. void setDescription(String description), String getDescription(), void clearDescription()
			 */
			testId++;
			e.setExpressionString("c1+a2");
			syn1 = e.checkSyntax();
			e.setDescription("opis");
			s1 = e.getDescription();
			e.clearDescription();
			s2 = e.getDescription();
			syn2 = e.getSyntaxStatus();
			if (	s1.Equals("opis")
					&& s2.Equals("")
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 6. void setVerboseMode(), boolean getVerboseMode(), void setSilentMode()
			 */
			testId++;
			syn1 = e.checkSyntax();
			b1 = e.getVerboseMode();
			e.setVerboseMode();
			b2 = e.getVerboseMode();
			e.setSilentMode();
			b3 = e.getVerboseMode();
			syn2 = e.getSyntaxStatus();
			if (	b1 == false
					&& b2 == true
					&& b3 == false
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 7.
			 * public boolean getRecursiveMode()
			 */
			Function fa = new Function("f(x,y)=sin(x)+cos(y)");
			Function fb = new Function("f(x,y)=sin(x)+cos(y)+f(1,2)");
			testId++;
			syn1=fa.checkSyntax();
			syn2=fb.checkSyntax();
			b1 = fa.getRecursiveMode();
			b2 = fb.getRecursiveMode();
			if (	b1 == false
					&& b2 == true
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 8.
			 * Expression(String expressionString)
			 */
			testId++;
			e = new Expression("1+2");
			if (	e.getExpressionString().Equals("1+2")
					&& e.getArgumentsNumber() == 0
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 0	)
				test[testId] = true;
			/*
			 * 9.
			 * Expression(String expressionString)
			 */
			testId++;
			e = new Expression("1+2", a1, a2, a3);
			if (	e.getExpressionString().Equals("1+2")
					&& e.getArgumentsNumber() == 3
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 0	)
				test[testId] = true;
			/*
			 * 10.
			 * void addArguments(Argument... arguments)
			 * void addArguments( ArrayList<Argument> argumentsList)
			 * defineArguments(String... argumentsNames)
			 * defineArgument(String argumentName, double argumentValue)
			 */
			testId++;
			e = new Expression("1+2");
			syn1 = e.checkSyntax();
			e.addDefinitions(a6, a7);
			syn2 = e.getSyntaxStatus();
			syn3 = e.checkSyntax();
			e.addDefinitions(a1, a2, a3, a4, a5);
			syn4 = e.getSyntaxStatus();
			syn5 = e.checkSyntax();
			e.defineArguments("x1", "x2", "x3");
			syn6 = e.getSyntaxStatus();
			syn7 = e.checkSyntax();
			e.defineArgument("x", 1);
			syn8 = e.getSyntaxStatus();
			if (	e.getExpressionString().Equals("1+2")
					&& e.getArgumentsNumber() == 11
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 0
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					&& syn6 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn7 == Expression.NO_SYNTAX_ERRORS
					&& syn8 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
						)
				test[testId] = true;
			/*
			 * 11.
			 * int getArgumentIndex(String argumentName)
			 * Argument getArgument(String argumentName)
			 * Argument getArgument(int argumentIndex)
			 * int getArgumentsNumber()
			 */
			testId++;
			syn1 = e.checkSyntax();
			i1 = e.getArgumentIndex("asdsa"); //-1
			i2 = e.getArgumentIndex("x1"); //7
			A1 = e.getArgument("asasas"); //null
			A2 = e.getArgument("a2"); //a2
			A3 = e.getArgument(-1); //null
			A4 = e.getArgument(23);//null
			A5 = e.getArgument(1);//a7
			n1 = e.getArgumentsNumber();//11
			syn2 = e.getSyntaxStatus();
			if (	i1 == -1
					&& i2 == 7
					&& A1 == null
					&& A2 == a2
					&& A3 == null
					&& A4 == null
					&& A5 == a7
					&& n1 == 11
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 12.
			 * void setArgumentValue
			 * double getArgumentValue
			 */
			testId++;
			syn1 = e.checkSyntax();
			d1 = e.getArgumentValue("a1");
			syn2 = e.getSyntaxStatus();
			e.setArgumentValue("asds", 1);
			syn3 = e.getSyntaxStatus();
			syn4 = e.checkSyntax();
			e.setArgumentValue("a1", 10);
			syn4 = e.getSyntaxStatus();
			d2 = e.getArgumentValue("asdfasdf");
			d3 = e.getArgumentValue("a1");
			syn5 = e.getSyntaxStatus();
			if (	d1 == 1
					&& Double.IsNaN(d2)
					&& d3 == 10
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.NO_SYNTAX_ERRORS
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 13.
			 * void removeArguments(String... argumentsNames)
			 * void removeArguments(Argument... arguments)
			 * void removeAllArguments()
			 */
			testId++;
			e.setExpressionString("1+2");
			syn1 = e.checkSyntax();
			n1 = e.getArgumentsNumber();
			e.removeArguments("asfdf");
			syn2 = e.getSyntaxStatus();
			n2 = e.getArgumentsNumber();
			e.removeArguments("x1","x2");
			n3 = e.getArgumentsNumber();
			syn3 = e.checkSyntax();
			e.removeArguments(a3);
			n4 = e.getArgumentsNumber();
			e.removeArguments(a1,a2);
			syn4 = e.getSyntaxStatus();
			n5 = e.getArgumentsNumber();
			syn5 = e.checkSyntax();
			e.removeAllArguments();
			n6 = e.getArgumentsNumber();
			syn6 = e.getSyntaxStatus();
			if (	n2 == n1
					&& n2-n3 == 2
					&& n3-n4 == 1
					&& n4-n5 == 2
					&& n6 == 0
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					&& syn6 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					)
				test[testId] = true;
			/*
			 * 14.
			 * void addConstants(Constant... constants)
			 * void addConstants( ArrayList<Constant> constantsList)
			 * void defineConstant(String constantName, double constantValue)
			 */
			testId++;
			e = new Expression("1+2", new Constant("a=5"));
			syn1 = e.checkSyntax();
			e.addDefinitions(c5, c6);
			syn2 = e.getSyntaxStatus();
			syn3 = e.checkSyntax();
			e.addDefinitions(c1, c2, c3, c5, c6);
			syn4 = e.getSyntaxStatus();
			syn5 = e.checkSyntax();
			e.defineConstant("cx1",1);
			e.removeDefinitions(c5, c6);
			syn6 = e.checkSyntax();
			e.removeDefinitions(c5, c6);
			if (	e.getExpressionString().Equals("1+2")
					&& e.getArgumentsNumber() == 0
					&& e.getConstantsNumber() == 5
					&& e.getFunctionsNumber() == 0
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn5 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn6 == Expression.NO_SYNTAX_ERRORS
						)
				test[testId] = true;
			/*
			 * 15.
			 * int getConstantIndex(String constantName)
			 * Constant getConstant(String constantName)
			 * Constant getConstant(int constantIndex)
			 * int getConstantsNumber()
			 */
			testId++;
			syn1 = e.checkSyntax();
			i1 = e.getConstantIndex("asdsa"); //-1
			i2 = e.getConstantIndex("c6"); //-1
			C1 = e.getConstant("asasas"); //null
			C2 = e.getConstant("c1"); //c1
			C3 = e.getConstant(-1); //null
			C4 = e.getConstant(23);//null
			C5 = e.getConstant(1);//c1
			n1 = e.getConstantsNumber();//5
			syn2 = e.getSyntaxStatus();
			if (	i1 == -1
					&& i2 == -1
					&& C1 == null
					&& C2 == c1
					&& C3 == null
					&& C4 == null
					&& C5 == c1
					&& n1 == 5
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 16.
			 * void removeConstants(String... constantsNames)
			 * void removeConstants(Constant... constants)
			 * void removeAllConstants()
			 */
			testId++;
			e.defineConstant("cx2",1);
			e.setExpressionString("1+2");
			syn1 = e.checkSyntax();
			n1 = e.getConstantsNumber();
			e.removeConstants("asfdf");
			syn2 = e.getSyntaxStatus();
			n2 = e.getConstantsNumber();
			e.removeConstants("cx1","cx2");
			n3 = e.getConstantsNumber();
			syn3 = e.checkSyntax();
			e.removeConstants(c1);
			n4 = e.getConstantsNumber();
			e.removeConstants(c2,c3);
			syn4 = e.getSyntaxStatus();
			n5 = e.getConstantsNumber();
			syn5 = e.checkSyntax();
			e.removeAllConstants();
			n6 = e.getConstantsNumber();
			syn6 = e.getSyntaxStatus();
			if (	n2 == n1
					&& n2-n3 == 2
					&& n3-n4 == 1
					&& n4-n5 == 2
					&& n6 == 0
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					&& syn6 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					)
				test[testId] = true;
			/*
			 * 17.
			 * void addFunctions(Function... functions)
			 * void addFunctions( ArrayList<Function> functionsList)
			 * void defineFunction(String functionName, String  functionExpressionString,...
			 */
			testId++;
			e = new Expression("1+2");
			syn1 = e.checkSyntax();
			e.addDefinitions(f6, f7);
			syn2 = e.getSyntaxStatus();
			syn3 = e.checkSyntax();
			e.addDefinitions(f1, f2, f3, f4, f6);
			syn4 = e.getSyntaxStatus();
			e.removeDefinitions(f6);
			syn5 = e.checkSyntax();
			e.defineFunction("ff1", "1", "x");
			syn6 = e.getSyntaxStatus();
			if (	e.getExpressionString().Equals("1+2")
					&& e.getArgumentsNumber() == 0
					&& e.getConstantsNumber() == 0
					&& e.getFunctionsNumber() == 7
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					&& syn6 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
						)
				test[testId] = true;
			/*
			 * 18.
			 * int getFunctionIndex(String functionName)
			 * Function getFunction(String functionName)
			 * Function getFunction(int functionIndex)
			 * int getFunctionsNumber()
			 */
			testId++;
			syn1 = e.checkSyntax();
			i1 = e.getFunctionIndex("asdsa"); //-1
			i2 = e.getFunctionIndex("f7"); //0
			F1 = e.getFunction("asasas"); //null
			F2 = e.getFunction("f1"); //f1
			F3 = e.getFunction(-1); //null
			F4 = e.getFunction(23);//null
			F5 = e.getFunction(0);//f7
			n1 = e.getFunctionsNumber();//7
			syn2 = e.getSyntaxStatus();
			if (	i1 == -1
					&& i2 == 0
					&& F1 == null
					&& F2 == f1
					&& F3 == null
					&& F4 == null
					&& F5 == f7
					&& n1 == 7
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					)
				test[testId] = true;
			/*
			 * 19.
			 * void removeFunctions(String... functionsNames)
			 * void removeFunctions(Function... functions)
			 * void removeAllFunctions()
			 */
			testId++;
			e.setExpressionString("1+2");
			syn1 = e.checkSyntax();
			n1 = e.getFunctionsNumber();
			e.removeFunctions("asfdf");
			syn2 = e.getSyntaxStatus();
			n2 = e.getFunctionsNumber();
			e.removeFunctions("f1","f2");
			n3 = e.getFunctionsNumber();
			syn3 = e.checkSyntax();
			e.removeFunctions(f3);
			n4 = e.getFunctionsNumber();
			e.removeFunctions(f6,f7);
			syn4 = e.getSyntaxStatus();
			n5 = e.getFunctionsNumber();
			syn5 = e.checkSyntax();
			e.removeAllFunctions();
			n6 = e.getFunctionsNumber();
			syn6 = e.getSyntaxStatus();
			if (	n2 == n1
					&& n2-n3 == 2
					&& n3-n4 == 1
					&& n4-n5 == 2
					&& n6 == 0
					&& syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn3 == Expression.NO_SYNTAX_ERRORS
					&& syn4 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					&& syn5 == Expression.NO_SYNTAX_ERRORS
					&& syn6 == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN
					)
				test[testId] = true;
			/*
			 * 20.
			 * double calculate()
			 * String getHelp()
			 * String getHelp(String word)
			 * String getLicense()
			 */
			testId++;
			syn1 = e.checkSyntax();
			d1 = e.calculate();
			syn2 = e.getSyntaxStatus();
			if (	syn1 == Expression.NO_SYNTAX_ERRORS
					&& syn2 == Expression.NO_SYNTAX_ERRORS
					&& d1 == 3)
				test[testId] = true;

			/*
			 * 21. Tokens
			 */
			testId++;
			e = new Expression("1+(2+3)-sin(10)");
			List<Token> tokens = e.getCopyOfInitialTokens();
			mXparser.consolePrintTokens(tokens);
			if (
					(tokens[0].tokenStr.Equals("1")) &&
					(tokens[1].tokenStr.Equals("+")) &&
					(tokens[2].tokenStr.Equals("(")) &&
					(tokens[3].tokenStr.Equals("2")) &&
					(tokens[4].tokenStr.Equals("+")) &&
					(tokens[5].tokenStr.Equals("3")) &&
					(tokens[6].tokenStr.Equals(")")) &&
					(tokens[7].tokenStr.Equals("-")) &&
					(tokens[8].tokenStr.Equals("sin")) &&
					(tokens[9].tokenStr.Equals("(")) &&
					(tokens[10].tokenStr.Equals("10")) &&
					(tokens[11].tokenStr.Equals(")")) &&

					(tokens[0].tokenTypeId == ParserSymbol.NUMBER_TYPE_ID) &&
					(tokens[1].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[2].tokenTypeId == ParserSymbol.TYPE_ID) &&
					(tokens[3].tokenTypeId == ParserSymbol.NUMBER_TYPE_ID) &&
					(tokens[4].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[5].tokenTypeId == ParserSymbol.NUMBER_TYPE_ID) &&
					(tokens[6].tokenTypeId == ParserSymbol.TYPE_ID) &&
					(tokens[7].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[8].tokenTypeId == Function1Arg.TYPE_ID) &&
					(tokens[9].tokenTypeId == ParserSymbol.TYPE_ID) &&
					(tokens[10].tokenTypeId == ParserSymbol.NUMBER_TYPE_ID) &&
					(tokens[11].tokenTypeId == ParserSymbol.TYPE_ID) &&

					(tokens[0].tokenLevel == 0) &&
					(tokens[1].tokenLevel == 0) &&
					(tokens[2].tokenLevel == 1) &&
					(tokens[3].tokenLevel == 1) &&
					(tokens[4].tokenLevel == 1) &&
					(tokens[5].tokenLevel == 1) &&
					(tokens[6].tokenLevel == 1) &&
					(tokens[7].tokenLevel == 0) &&
					(tokens[8].tokenLevel == 1) &&
					(tokens[9].tokenLevel == 2) &&
					(tokens[10].tokenLevel == 2) &&
					(tokens[11].tokenLevel == 2)

			) test[testId] = true;
			/*
			 * 22. Invalid tokens
			 */
			testId++;
			e = new Expression("token1+toke2n*sin(token3-t3^t5)^t45+pi-pie+e");
			tokens = e.getCopyOfInitialTokens();
			mXparser.consolePrintTokens(tokens);
			if (
					(tokens[0].tokenStr.Equals("token1")) &&
					(tokens[1].tokenStr.Equals("+")) &&
					(tokens[2].tokenStr.Equals("toke2n")) &&
					(tokens[3].tokenStr.Equals("*")) &&
					(tokens[4].tokenStr.Equals("sin")) &&
					(tokens[5].tokenStr.Equals("(")) &&
					(tokens[6].tokenStr.Equals("token3")) &&
					(tokens[7].tokenStr.Equals("-")) &&
					(tokens[8].tokenStr.Equals("t3")) &&
					(tokens[9].tokenStr.Equals("^")) &&
					(tokens[10].tokenStr.Equals("t5")) &&
					(tokens[11].tokenStr.Equals(")")) &&
					(tokens[12].tokenStr.Equals("^")) &&
					(tokens[13].tokenStr.Equals("t45")) &&
					(tokens[14].tokenStr.Equals("+")) &&
					(tokens[15].tokenStr.Equals("pi")) &&
					(tokens[16].tokenStr.Equals("-")) &&
					(tokens[17].tokenStr.Equals("pie")) &&
					(tokens[18].tokenStr.Equals("+")) &&
					(tokens[19].tokenStr.Equals("e")) &&

					(tokens[0].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[1].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[2].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[3].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[4].tokenTypeId == Function1Arg.TYPE_ID) &&
					(tokens[5].tokenTypeId == ParserSymbol.TYPE_ID) &&
					(tokens[6].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[7].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[8].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[9].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[10].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[11].tokenTypeId == ParserSymbol.TYPE_ID) &&
					(tokens[12].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[13].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[14].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[15].tokenTypeId == ConstantValue.TYPE_ID) &&
					(tokens[16].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[17].tokenTypeId == Token.NOT_MATCHED) &&
					(tokens[18].tokenTypeId == Operator.TYPE_ID) &&
					(tokens[19].tokenTypeId == ConstantValue.TYPE_ID) &&

					(tokens[0].tokenLevel == 0) &&
					(tokens[1].tokenLevel == 0) &&
					(tokens[2].tokenLevel == 0) &&
					(tokens[3].tokenLevel == 0) &&
					(tokens[4].tokenLevel == 1) &&
					(tokens[5].tokenLevel == 2) &&
					(tokens[6].tokenLevel == 2) &&
					(tokens[7].tokenLevel == 2) &&
					(tokens[8].tokenLevel == 2) &&
					(tokens[9].tokenLevel == 2) &&
					(tokens[10].tokenLevel == 2) &&
					(tokens[11].tokenLevel == 2) &&
					(tokens[12].tokenLevel == 0) &&
					(tokens[13].tokenLevel == 0) &&
					(tokens[14].tokenLevel == 0) &&
					(tokens[15].tokenLevel == 0) &&
					(tokens[16].tokenLevel == 0) &&
					(tokens[17].tokenLevel == 0) &&
					(tokens[18].tokenLevel == 0) &&
					(tokens[19].tokenLevel == 0)

			) test[testId] = true;
			/*
			 * 23. Function Extension - calculate()
			 */
			testId++;
			Function ff = new Function("ff", new FunExt());
			if (ff.calculate(2, 3) == 6) test[testId] = true;
			/*
			 * 24. Function Extension - setArgumentValue - calculate
			 */
			testId++;
			ff = new Function("ff", new FunExt());
			ff.setArgumentValue(0, 3);
			ff.setArgumentValue(1, 4);
			if (ff.calculate() == 12) test[testId] = true;
			/*
			 * 25. Function Extension - parameters
			 */
			testId++;
			ff = new Function("ff", new FunExt());
			if (
					(ff.getParametersNumber() == 2) &&
					(ff.getFunctionBodyType() == Function.BODY_EXTENDED) &&
					(ff.checkSyntax() == Function.NO_SYNTAX_ERRORS)
				) test[testId] = true;
			/*
			 * 26. Function Extension - calculate
			 */
			testId++;
			ff = new Function("ff", new FunExt());
			Argument x = new Argument("x = 5");
			Argument y = new Argument("y = 6");
			if (ff.calculate(x, y) == 30) test[testId] = true;
			/*
			 * 27. Invalid tokens looks like
			 */
			testId++;
			e = new Expression("1pi+2pi3+((_d1(a)+(_d^_g)))))");
			tokens = e.getCopyOfInitialTokens();
			mXparser.consolePrintTokens(tokens);
			if (
					(tokens[0].tokenStr.Equals("1pi")) &&
					(tokens[1].tokenStr.Equals("+")) &&
					(tokens[2].tokenStr.Equals("2pi3")) &&
					(tokens[3].tokenStr.Equals("+")) &&
					(tokens[4].tokenStr.Equals("(")) &&
					(tokens[5].tokenStr.Equals("(")) &&
					(tokens[6].tokenStr.Equals("_d1")) &&
					(tokens[7].tokenStr.Equals("(")) &&
					(tokens[8].tokenStr.Equals("a")) &&
					(tokens[9].tokenStr.Equals(")")) &&
					(tokens[10].tokenStr.Equals("+")) &&
					(tokens[11].tokenStr.Equals("(")) &&
					(tokens[12].tokenStr.Equals("_d")) &&
					(tokens[13].tokenStr.Equals("^")) &&
					(tokens[14].tokenStr.Equals("_g")) &&
					(tokens[15].tokenStr.Equals(")")) &&
					(tokens[16].tokenStr.Equals(")")) &&
					(tokens[17].tokenStr.Equals(")")) &&
					(tokens[18].tokenStr.Equals(")")) &&
					(tokens[19].tokenStr.Equals(")")) &&

					(tokens[0].looksLike.Equals("error")) &&
					(tokens[2].looksLike.Equals("error")) &&
					(tokens[6].looksLike.Equals("function")) &&
					(tokens[8].looksLike.Equals("argument")) &&
					(tokens[12].looksLike.Equals("argument")) &&
					(tokens[14].looksLike.Equals("argument"))
				) test[testId] = true;
			/*
			 * 28. Check Lex Syntax
			 */
			testId++;
			e = new Expression("1+2+3+(4+5)+a+b");
			if (
					(e.checkSyntax() == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN) &&
					(e.checkLexSyntax() == Expression.NO_SYNTAX_ERRORS)
				) test[testId] = true;
			/*
			 * 29. Check Lex Syntax
			 */
			testId++;
			e = new Expression("1+2+3+(4+5)+a)+b");
			if (
					(e.checkSyntax() == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN) &&
					(e.checkLexSyntax() == Expression.SYNTAX_ERROR_OR_STATUS_UNKNOWN)
				) test[testId] = true;
			/*
			 * 30. Tokens to remove
			 */
			testId++;
			String t = null;
			mXparser.removeBuiltinTokens("sin");
			mXparser.removeBuiltinTokens("sin");
			mXparser.removeBuiltinTokens("cos");
			mXparser.removeBuiltinTokens("sin");
			mXparser.removeBuiltinTokens("sin", "cos", t, "", "tg");
			mXparser.removeBuiltinTokens(t);
			mXparser.unremoveBuiltinTokens(t);
			mXparser.unremoveBuiltinTokens(t, "");
			mXparser.unremoveBuiltinTokens("sin", "tg");
			String[] tokensToRemove1 = mXparser.getBuiltinTokensToRemove();
			mXparser.unremoveAllBuiltinTokens();
			String[] tokensToRemove2 = mXparser.getBuiltinTokensToRemove();
			if (
					(tokensToRemove1.Length == 1) &&
					(tokensToRemove1[0].Equals("cos")) &&
					(tokensToRemove2.Length == 0)
				) test[testId] = true;
			/*
			 * 31. Tokens to modify
			 */
			String u = null;
			testId++;
			mXparser.modifyBuiltinToken("sin", "SIN");
			mXparser.modifyBuiltinToken("cos", "");
			mXparser.modifyBuiltinToken("tan", u);
			mXparser.modifyBuiltinToken(u, u);
			mXparser.modifyBuiltinToken(u, "TAN");
			mXparser.modifyBuiltinToken("tg", "TG", "NEW TG");
			mXparser.modifyBuiltinToken("", "TG", "NEW TG");
			mXparser.modifyBuiltinToken(u, "TG", "NEW TG");
			mXparser.modifyBuiltinToken("sin", "TG", "NEW TG");
			mXparser.modifyBuiltinToken("cos", "COS", "NEW COS");
			mXparser.modifyBuiltinToken("cos", "COS1", "NEW COS1");
			String[,] tokensToModify1 = mXparser.getBuiltinTokensToModify();
			mXparser.unmodifyBuiltinTokens("", u, "SIN", "tg");
			String[,] tokensToModify2 = mXparser.getBuiltinTokensToModify();
			mXparser.unmodifyAllBuiltinTokens();
			String[,] tokensToModify3 = mXparser.getBuiltinTokensToModify();
			if (
					(tokensToModify1.GetLength(0) == 3) && (tokensToModify1.GetLength(1) == 3) &&
					(tokensToModify2.GetLength(0) == 1) && (tokensToModify2.GetLength(1) == 3) &&
					(tokensToModify3.GetLength(0) == 0) &&
					(tokensToModify1[0, 0].Equals("sin")) &&
					(tokensToModify1[0, 1].Equals("SIN")) &&
					(tokensToModify1[0, 2] == null) &&
					(tokensToModify1[1, 0].Equals("tg")) &&
					(tokensToModify1[1, 1].Equals("TG")) &&
					(tokensToModify1[1, 2].Equals("NEW TG")) &&
					(tokensToModify1[2, 0].Equals("cos")) &&
					(tokensToModify1[2, 1].Equals("COS")) &&
					(tokensToModify1[2, 2].Equals("NEW COS")) &&
					(tokensToModify2[0, 0].Equals("cos")) &&
					(tokensToModify2[0, 1].Equals("COS")) &&
					(tokensToModify2[0, 2].Equals("NEW COS"))
					) test[testId] = true;
			/* ============================================= */
			long end =  mXparser.currentTimeMillis();
			int nOk = 0;
			int nError = 0;
			for (int i = 0; i <= testId; i++) {
				if (test[i]) {
					nOk++;
					mXparser.consolePrintln("[" + i + "] " + "OK");
				} else {
					nError++;
					mXparser.consolePrintln("[" + i + "] " + "ERROR");
				}
			}
			mXparser.consolePrintln("OK : " + nOk + ", ERRORs: " + nError + ", total time: " + (end-start)/1000.0 + " s.");
			for (int i = 0; i <= testId; i++) {
				if (!test[i])
					mXparser.consolePrintln("ERROR: " + testId);
			}
			return nError;
		}
		/**
		 * Runs API regression tests.
		 */
		public static void Main(string[] args) {
			Start();
		}
	}
}