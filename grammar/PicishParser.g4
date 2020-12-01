// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

parser grammar PicishParser;

options { tokenVocab=PicishLexer; }

file
    : statement* EOF
    ;

statement
    : shape SEMI
    | direction SEMI
    ;

direction
    : UP
    | DOWN
    | LEFT
    | RIGHT
    | MOVE
    ;

// TODO - line should be separate - box shapes vs others?
shape
    : BOX
    | CIRCLE
    | LINE
    ;

