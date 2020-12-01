// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

lexer grammar PicishLexer;

BOX:    'box';
CIRCLE: 'circle';
LINE:   'line';

DOWN:   'down';
LEFT:   'left';
RIGHT:  'right';
UP:     'up';
MOVE:   'move';

SEMI:   ';';

WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines

LINE_COMMENT : '//' ~[\r\n]* -> skip ;

