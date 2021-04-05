/*
Error: File to import not found or unreadable: ../node_modules/bootstrap/scss/bootstrap.
        on line 6 of scss/main.scss

1: //Custom scss
2: @import "my_variables";
3: @import "functions";
4: 
5: //Import bootstrap css needed
6: @import "../node_modules/bootstrap/scss/bootstrap";
7: 
8: //Custom scss
9: @import "custom";

Backtrace:
scss/main.scss:6
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/import_node.rb:67:in `rescue in import'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/import_node.rb:44:in `import'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/import_node.rb:28:in `imported_file'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/import_node.rb:37:in `css_import?'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/perform.rb:310:in `visit_import'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/base.rb:36:in `visit'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/perform.rb:158:in `block in visit'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/stack.rb:79:in `block in with_base'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/stack.rb:135:in `with_frame'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/stack.rb:79:in `with_base'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/perform.rb:158:in `visit'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/base.rb:52:in `block in visit_children'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/base.rb:52:in `map'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/base.rb:52:in `visit_children'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/perform.rb:167:in `block in visit_children'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/perform.rb:179:in `with_environment'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/perform.rb:166:in `visit_children'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/base.rb:36:in `block in visit'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/perform.rb:186:in `visit_root'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/base.rb:36:in `visit'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/perform.rb:157:in `visit'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/visitors/perform.rb:10:in `visit'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/root_node.rb:36:in `css_tree'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/tree/root_node.rb:29:in `render_with_sourcemap'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/engine.rb:389:in `_render_with_sourcemap'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/engine.rb:307:in `render_with_sourcemap'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/plugin/compiler.rb:462:in `update_stylesheet'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/plugin/compiler.rb:215:in `block in update_stylesheets'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/plugin/compiler.rb:209:in `each'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/plugin/compiler.rb:209:in `update_stylesheets'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/plugin/compiler.rb:294:in `watch'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/plugin.rb:109:in `method_missing'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/exec/sass_scss.rb:358:in `watch_or_update'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/exec/sass_scss.rb:51:in `process_result'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/exec/base.rb:50:in `parse'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/lib/sass/exec/base.rb:18:in `parse!'
C:/Ruby27-x64/lib/ruby/gems/2.7.0/gems/sass-3.7.4/bin/sass:13:in `<top (required)>'
C:/Ruby27-x64/bin/sass:23:in `load'
C:/Ruby27-x64/bin/sass:23:in `<main>'
*/
body:before {
  white-space: pre;
  font-family: monospace;
  content: "Error: File to import not found or unreadable: ../node_modules/bootstrap/scss/bootstrap.\A         on line 6 of scss/main.scss\A \A 1: //Custom scss\A 2: @import \"my_variables\";\A 3: @import \"functions\";\A 4: \A 5: //Import bootstrap css needed\A 6: @import \"../node_modules/bootstrap/scss/bootstrap\";\A 7: \A 8: //Custom scss\A 9: @import \"custom\";"; }
