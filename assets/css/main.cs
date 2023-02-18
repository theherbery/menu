/*
Error: Invalid CSS after "...ort 'libs/vars'": expected selector or at-rule, was "@import 'libs/f..."
        on line 2 of main.scss

1: @import 'libs/vars'
2: @import 'libs/functions'
3: @import 'libs/mixins'
4: @import 'libs/vendor'
5: @import 'libs/breakpoints'
6: @import 'libs/html-grid'
7: @import url("fontawesome-all.min.css")

Backtrace:
main.scss:2
/usr/share/gems/gems/sass-3.7.4/lib/sass/scss/parser.rb:1308:in `expected'
/usr/share/gems/gems/sass-3.7.4/lib/sass/scss/parser.rb:1238:in `expected'
/usr/share/gems/gems/sass-3.7.4/lib/sass/scss/parser.rb:42:in `parse'
/usr/share/gems/gems/sass-3.7.4/lib/sass/engine.rb:414:in `_to_tree'
/usr/share/gems/gems/sass-3.7.4/lib/sass/engine.rb:389:in `_render_with_sourcemap'
/usr/share/gems/gems/sass-3.7.4/lib/sass/engine.rb:307:in `render_with_sourcemap'
/usr/share/gems/gems/sass-3.7.4/lib/sass/exec/sass_scss.rb:387:in `run'
/usr/share/gems/gems/sass-3.7.4/lib/sass/exec/sass_scss.rb:63:in `process_result'
/usr/share/gems/gems/sass-3.7.4/lib/sass/exec/base.rb:50:in `parse'
/usr/share/gems/gems/sass-3.7.4/lib/sass/exec/base.rb:18:in `parse!'
/usr/share/gems/gems/sass-3.7.4/bin/sass:13:in `<top (required)>'
/usr/bin/sass:25:in `load'
/usr/bin/sass:25:in `<main>'
*/
body:before {
  white-space: pre;
  font-family: monospace;
  content: "Error: Invalid CSS after \"...ort 'libs/vars'\": expected selector or at-rule, was \"@import 'libs/f...\"\A         on line 2 of main.scss\A \A 1: @import 'libs/vars'\A 2: @import 'libs/functions'\A 3: @import 'libs/mixins'\A 4: @import 'libs/vendor'\A 5: @import 'libs/breakpoints'\A 6: @import 'libs/html-grid'\A 7: @import url(\"fontawesome-all.min.css\")"; }
