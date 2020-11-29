
GRAMMAR=Calculator
GRAMMAR_FILE=$(GRAMMAR).g4
ANTLR_JAR=$(HOME)/bin/antlr-4.9/antlr-4.9-complete.jar
SHARPDIR=csharp
OUTDIR=../src/Grammar

GRAM_FILES=\
		   $(SHARPDIR)/$(GRAMMAR)BaseVisitor.cs \
		   $(SHARPDIR)/$(GRAMMAR)Lexer.cs \
		   $(SHARPDIR)/$(GRAMMAR)Parser.cs \
		   $(SHARPDIR)/$(GRAMMAR)Visitor.cs

OUT_FILES=\
		  $(OUTDIR)/$(GRAMMAR)BaseVisitor.cs \
		  $(OUTDIR)/$(GRAMMAR)Lexer.cs \
          $(OUTDIR)/$(GRAMMAR)Parser.cs \
          $(OUTDIR)/I$(GRAMMAR)Visitor.cs

.PHONY: build

build: $(OUT_FILES)

$(OUTDIR)/$(GRAMMAR)BaseVisitor.cs : $(SHARPDIR)/$(GRAMMAR)BaseVisitor.cs $(OUTDIR)
	cp $< $@

$(OUTDIR)/$(GRAMMAR)Lexer.cs : $(SHARPDIR)/$(GRAMMAR)Lexer.cs $(OUTDIR)
	cp $< $@

$(OUTDIR)/$(GRAMMAR)Parser.cs : $(SHARPDIR)/$(GRAMMAR)Parser.cs $(OUTDIR)
	cp $< $@

$(OUTDIR)/I$(GRAMMAR)Visitor.cs : $(SHARPDIR)/$(GRAMMAR)Visitor.cs $(OUTDIR)
	cp $< $@

$(OUTDIR):
	mkdir $(OUTDIR)

$(GRAM_FILES): $(GRAMMAR_FILE)
	java -Xmx500M -cp "$(ANTLR_JAR)" org.antlr.v4.Tool -Dlanguage=CSharp -o $(SHARPDIR) $(GRAMMAR_FILE) -no-listener -visitor

clean:
	rm -rf $(SHARPDIR)

