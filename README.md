# ImplementeringProgrammeringssprog
Implementering af programmeringssprog
\\
\\compile:
\\
\\(inde i fasto)
\\\$ export PATH=/Library/Frameworks/Mono.framework/Commands:$PATH
\\\$ make
\\(ude for fasto)
\\(lexer)
\\\$ mono fasto/lib/fslex.exe fasto/src/Lexer.fsl
\\(parser)
\\\$ mono fasto\lib\fsyacc.exe -v --module Parser fasto\src\Parser.fsp 
\\\(test test filer)
\\\$ fasto/bin/runtests.sh fasto/tests
