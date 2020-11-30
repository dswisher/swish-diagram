// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

lexer grammar PicishLexer;

BOX:    'box';
LINE:   'line';

SEMI:   ';';

WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines

