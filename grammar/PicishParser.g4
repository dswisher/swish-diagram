// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

parser grammar PicishParser;

options { tokenVocab=PicishLexer; }

file
    : statement* EOF
    ;

statement
    : shape SEMI
    ;

shape
    : BOX
    | LINE
    ;

