
ANTLR_JAR=$(HOME)/bin/antlr-4.9/antlr-4.9-complete.jar

GRAMMAR=Picish
LEXER_FILE=$(GRAMMAR)Lexer.g4
PARSER_FILE=$(GRAMMAR)Parser.g4
SHARPDIR=csharp
OUTDIR=../src/Grammar

LEXER_CS=\
		 $(SHARPDIR)/$(GRAMMAR)Lexer.cs

PARSER_CS=\
		  $(SHARPDIR)/$(GRAMMAR)ParserBaseVisitor.cs \
		  $(SHARPDIR)/$(GRAMMAR)Parser.cs \
		  $(SHARPDIR)/$(GRAMMAR)ParserVisitor.cs

OUT_FILES=\
		  $(OUTDIR)/$(GRAMMAR)ParserBaseVisitor.cs \
		  $(OUTDIR)/$(GRAMMAR)Lexer.cs \
          $(OUTDIR)/$(GRAMMAR)Parser.cs \
          $(OUTDIR)/I$(GRAMMAR)ParserVisitor.cs

.PHONY: build clean

build: $(OUT_FILES)

$(PARSER_CS) $(LEXER_CS): $(PARSER_FILE) $(LEXER_FILE)
	java -Xmx500M -cp "$(ANTLR_JAR)" org.antlr.v4.Tool -Dlanguage=CSharp -o $(SHARPDIR) $(LEXER_FILE) $(PARSER_FILE) -no-listener -visitor

$(OUTDIR)/$(GRAMMAR)ParserBaseVisitor.cs : $(SHARPDIR)/$(GRAMMAR)ParserBaseVisitor.cs $(OUTDIR)
	cp $< $@

$(OUTDIR)/$(GRAMMAR)Lexer.cs : $(SHARPDIR)/$(GRAMMAR)Lexer.cs $(OUTDIR)
	cp $< $@

$(OUTDIR)/$(GRAMMAR)Parser.cs : $(SHARPDIR)/$(GRAMMAR)Parser.cs $(OUTDIR)
	cp $< $@

$(OUTDIR)/I$(GRAMMAR)ParserVisitor.cs : $(SHARPDIR)/$(GRAMMAR)ParserVisitor.cs $(OUTDIR)
	cp $< $@

$(OUTDIR):
	mkdir $(OUTDIR)

clean:
	rm -rf $(SHARPDIR)

