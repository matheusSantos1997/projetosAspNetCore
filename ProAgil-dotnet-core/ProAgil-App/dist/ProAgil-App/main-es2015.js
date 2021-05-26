(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./$$_lazy_route_resource lazy recursive":
/*!******************************************************!*\
  !*** ./$$_lazy_route_resource lazy namespace object ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/app.component.html":
/*!**************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/app.component.html ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<app-nav></app-nav>\n<div class=\"container\">\n<router-outlet></router-outlet>\n</div>\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/contatos/contatos.component.html":
/*!****************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/contatos/contatos.component.html ***!
  \****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<app-titulo [title]=\"tituloContatos\"></app-titulo>\n<p>\n  contatos works!\n</p>\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/dashboard/dashboard.component.html":
/*!******************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/dashboard/dashboard.component.html ***!
  \******************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"container mt-4\">\n  <div class=\"row mbr-justify-content-center\">\n  \n    <div class=\"col-lg-6 mbr-col-md-10\">\n        <div class=\"wrap\">\n            <div class=\"ico-wrap\">\n                <span class=\"mbr-iconfont fa-volume-up fa\"></span>\n            </div>\n            <div class=\"text-wrap vcenter\">\n                <h2 class=\"mbr-fonts-style mbr-bold mbr-section-title3 display-5\">Stay <span>Successful</span></h2>\n                <p class=\"mbr-fonts-style text1 mbr-text display-6\">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum</p>\n            </div>\n        </div>\n    </div>\n    <div class=\"col-lg-6 mbr-col-md-10\">\n        <div class=\"wrap\">\n            <div class=\"ico-wrap\">\n                <span class=\"mbr-iconfont fa-calendar fa\"></span>\n            </div>\n            <div class=\"text-wrap vcenter\">\n                <h2 class=\"mbr-fonts-style mbr-bold mbr-section-title3 display-5\">Create\n                    <span>An Effective Team</span>\n                </h2>\n                <p class=\"mbr-fonts-style text1 mbr-text display-6\">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum</p>\n            </div>\n        </div>\n    </div>\n    <div class=\"col-lg-6 mbr-col-md-10\">\n        <div class=\"wrap\">\n            <div class=\"ico-wrap\">\n                <span class=\"mbr-iconfont fa-globe fa\"></span>\n            </div>\n            <div class=\"text-wrap vcenter\">\n                <h2 class=\"mbr-fonts-style mbr-bold mbr-section-title3 display-5\">Launch\n                    <span>A Unique Project</span>\n                </h2>\n                <p class=\"mbr-fonts-style text1 mbr-text display-6\">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum</p>\n            </div>\n        </div>\n    </div>\n    <div class=\"col-lg-6 mbr-col-md-10\">\n        <div class=\"wrap\">\n            <div class=\"ico-wrap\">\n                <span class=\"mbr-iconfont fa-trophy fa\"></span>\n            </div>\n            <div class=\"text-wrap vcenter\">\n                <h2 class=\"mbr-fonts-style mbr-bold mbr-section-title3 display-5\">Achieve <span>Your Targets</span></h2>\n                <p class=\"mbr-fonts-style text1 mbr-text display-6\">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum</p>\n            </div>\n        </div>\n      </div>\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/evento/evento.component.html":
/*!************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/evento/evento.component.html ***!
  \************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<app-titulo [title]=\"tituloEvento\"></app-titulo>\n<div class=\"d-flex\">\n\n    <div class=\"form-inline mr-auto\">\n        <div class=\"form-group mb-2\">\n            <label class=\"mr-2\">Filtro:</label>\n            <!-- ngModel para filtrar os registros -->\n            <input type=\"text\" class=\"form-control mr-2\" placeholder=\"buscar...\" [(ngModel)]=\"filtroLista\">\n            <button class=\"btn btn-outline-success\">Buscar</button>\n        </div>\n    </div>\n\n    <div>\n        <button class=\"btn btn-outline-primary\" (click)=\"novoEvento(template)\">\n      <i class=\"fa fa-plus-circle\"></i>&nbsp;\n      Novo Evento\n   </button>\n    </div>\n\n</div>\n\n<h3>Filtro: {{filtroLista}}</h3>\n<table class=\"table table-striped\">\n    <thead class=\"thead-light\">\n        <tr>\n            <th>\n                <button class=\"btn btn-outline-primary\" (click)=\"alternarImagem()\">\n            <i class=\"{{mostrarImagem ? 'fa fa-eye' : 'fa fa-eye-slash'}}\"></i> \n            <!-- {{mostrarImagem ? 'Ocultar' : 'Mostrar'}} -->\n         </button>\n            </th>\n            <th>Id</th>\n            <th>Tema</th>\n            <th>Local</th>\n            <th>Data</th>\n            <th>Qtd Pessoas</th>\n            <th>Lote</th>\n            <th colspan=\"2\">Opções</th>\n        </tr>\n    </thead>\n    <!-- se eventos existe-->\n    <tbody *ngIf=\"eventos && eventos.length\">\n        <!-- monstrando todos os elementos -->\n        <tr *ngFor=\"let evento of eventosFiltrados || evento of eventos\">\n            <td>\n                <!-- vai mostrar as imagens cadastradas no banco -->\n                <img *ngIf=\"mostrarImagem\" src=\"http://localhost:5000/Resources/images/{{evento.imagemUrl}}? _ts={{dataAtual}}\" [style.width.px]=\"imagemLargura\" [style.margin.px]=\"imagemMargem\">\n                <!-- largura e margem da imagem-->\n            </td>\n\n            <td>{{evento.id}}</td>\n            <td>{{evento.tema}}</td>\n            <!-- <td>{{evento.tema | uppercase}}</td> -->\n            <td>{{evento.local}}</td>\n            <td>{{evento.dataEvento | DateTimeFormatPipe}}</td>\n            <td>{{evento.qtdPessoas}}</td>\n            <td>\n                <div *ngIf=\"!evento.lotes.length\">\n                    Não informado\n                </div>\n                <div *ngIf=\"evento.lotes.length\">\n                    {{evento.lotes[0].nome | uppercase}}\n                </div>\n            </td>\n            <td>\n                <div class=\"btn-group\">\n                    <button class=\"btn btn-sm btn-success\" tooltip=\"Editar\" (click)=\"editarEvento(evento, template)\">\n               <i class=\"fa fa-edit\"></i>\n               </button>\n                    <button class=\"btn btn-sm btn-danger\" tooltip=\"Excluir\" (click)=\"excluirEvento(evento, confirm)\">\n               <i class=\"fa fa-eraser\"></i>\n            </button>\n                </div>\n            </td>\n\n            <td>\n                <a [routerLink]=\"['/evento', evento.id, 'edit']\" tooltip=\"Edição Detalhada\" class=\"btn btn-sm btn-warning\">\n                    <i class=\"fa fa-edit\"></i>\n                </a>\n            </td>\n        </tr>\n    </tbody>\n    <tfoot>\n        <!-- se caso nao existir eventos registrados na base de dados -->\n        <tr *ngIf=\"!eventos\">\n            <td colspan=\"7\" class=\"text-center\">\n                <h4>Nenhum evento encontrado!</h4>\n            </td>\n        </tr>\n    </tfoot>\n</table>\n\n<!-- inserir de novos eventos -->\n<div bsModal #template=\"bs-modal\" class=\"modal fade\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"dialog-sizes-name1\">\n    <div class=\"modal-dialog modal-lg\">\n        <div class=\"modal-content\">\n            <div class=\"modal-header\">\n                <h4 id=\"dialog-sizes-name1\" class=\"modal-title pull-left\">Eventos</h4>\n                <button type=\"button\" class=\"close pull-right\" (click)=\"template.hide()\" aria-label=\"Close\">\n          <span aria-hidden=\"true\">&times;</span>\n        </button>\n            </div>\n            <div class=\"modal-body\">\n                <form [formGroup]=\"registerForm\">\n                    <div class=\"form-row\">\n                        <div class=\"form-group col-md-4\">\n                            <label>Tema</label>\n                            <input type=\"text\" class=\"form-control\" [ngClass]=\"{'is-invalid': registerForm.get('tema').errors && registerForm.get('tema').touched}\" formControlName=\"tema\" placeholder=\"Insira o Tema\" />\n\n                            <div *ngIf=\"registerForm.get('tema').hasError('required') && registerForm.get('tema').touched\" class=\"invalid-feedback\">\n                                O campo tema é obrigatório\n                            </div>\n\n                            <div *ngIf=\"registerForm.get('tema').hasError('minlength') && registerForm.get('tema').touched\" class=\"invalid-feedback\">\n                                O campo tema deve ter no mínimo 4 Caracteres\n                            </div>\n\n                            <div *ngIf=\"registerForm.get('tema').hasError('maxlength') && registerForm.get('tema').touched\" class=\"invalid-feedback\">\n                                O campo tema deve ter no máximo 50 caracteres\n                            </div>\n\n                        </div>\n\n                        <div class=\"form-group col-md-4\">\n                            <label>Local</label>\n                            <input type=\"text\" class=\"form-control\" [ngClass]=\"{'is-invalid': registerForm.get('local').errors && registerForm.get('local').touched}\" formControlName=\"local\" placeholder=\"Insira um Local\" />\n\n                            <div *ngIf=\"registerForm.get('local').hasError('required') && registerForm.get('local').touched\" class=\"invalid-feedback\">\n                                O campo Local é obrigatório\n                            </div>\n\n                            <div *ngIf=\"registerForm.get('local').hasError('maxlength') && registerForm.get('local').touched\" class=\"invalid-feedback\">\n                                O campo Local deve ter no máximo 30 caracteres\n                            </div>\n                        </div>\n\n                        <div class=\"form-group col-md-4\">\n                            <label>Data e Hora</label>\n                            <input type=\"text\" class=\"form-control\" bsDatepicker value=\"{{dataEvento | DateTimeFormatPipe}}\" [ngModel]=\"dataEvento\" [bsConfig]=\"{ dateInputFormat : 'DD/MM/YYYY hh:mm' }\" [ngClass]=\"{'is-invalid': registerForm.get('dataEvento').errors && \n               registerForm.get('dataEvento').touched}\" formControlName=\"dataEvento\" placeholder=\"insira uma data e hora\" />\n\n                            <div *ngIf=\"registerForm.get('dataEvento').hasError('required') && registerForm.get('dataEvento').touched\" class=\"invalid-feedback\">\n                                O campo data e hora é obrigatório\n                            </div>\n                        </div>\n\n                    </div>\n\n\n                    <div class=\"form-row\">\n                        <div class=\"form-group col-md-8\">\n                            <label>Qtd Pessoas</label>\n                            <input type=\"number\" class=\"form-control\" [ngClass]=\"{'is-invalid': registerForm.get('qtdPessoas').errors && registerForm.get('qtdPessoas').touched}\" formControlName=\"qtdPessoas\" placeholder=\"insira uma qtd de Pessoas\" />\n\n                            <div *ngIf=\"registerForm.get('qtdPessoas').hasError('required') && registerForm.get('qtdPessoas').touched\" class=\"invalid-feedback\">\n                                O campo Qtd Pessoas é obrigatório\n                            </div>\n\n                            <div *ngIf=\"registerForm.get('qtdPessoas').hasError('max') && registerForm.get('qtdPessoas').touched\" class=\"invalid-feedback\">\n                                O campo deve ser menor que 300\n                            </div>\n                        </div>\n                    </div>\n\n                    <div class=\"form-row\">\n                        <div class=\"form-group col-md-8\">\n                            <label>Imagem</label>\n                            <table>\n                                <tr>\n                                    <td>\n                                        <button class=\"btn btn-success\" (click)=\"file.click()\">Enviar Imagem</button>\n                                        <input type=\"file\" class=\"form-control is-invalid\" #file [ngClass]=\"{'is-invalid': registerForm.get('imagemUrl').errors && registerForm.get('imagemUrl').touched}\" (change)=\"onFileChange($event)\" formControlName=\"imagemUrl\" placeholder=\"insira uma imagem\"\n                                            style=\"display: none;\" />\n                                    </td>\n                                </tr>\n                            </table>\n                            <div *ngIf=\"registerForm.get('imagemUrl').hasError('required') && registerForm.get('imagemUrl').touched\" class=\"invalid-feedback\">\n                                O campo imagem é obrigatório\n                            </div>\n                        </div>\n                    </div>\n\n                    <div class=\"form-row\">\n                        <div class=\"form-group col-md-4\">\n                            <label>Telefone</label>\n                            <input type=\"text\" class=\"form-control\" [ngClass]=\"{'is-invalid': registerForm.get('telefone').errors && registerForm.get('telefone').touched}\" formControlName=\"telefone\" mask=\"(00)00000-0000\" placeholder=\"insira o seu telefone\" />\n\n                            <div *ngIf=\"registerForm.get('telefone').hasError('required') && registerForm.get('telefone').touched\" class=\"invalid-feedback\">\n                                O campo telefone é obrigatório\n                            </div>\n                        </div>\n                    </div>\n\n                    <div class=\"form-row\">\n                        <div class=\"form-group col-md-8\">\n                            <label>Email</label>\n                            <input type=\"text\" class=\"form-control\" [ngClass]=\"{'is-invalid': registerForm.get('email').errors && registerForm.get('email').touched}\" formControlName=\"email\" placeholder=\"insira o seu email\" />\n\n                            <div *ngIf=\"registerForm.get('email').hasError('required') && registerForm.get('email').touched\" class=\"invalid-feedback\">\n                                O campo email é obrigatório\n                            </div>\n\n                            <div *ngIf=\"registerForm.get('email').hasError('email') && registerForm.get('email').touched\" class=\"invalid-feedback\">\n                                Digite um email válido\n                            </div>\n\n                        </div>\n                    </div>\n                </form>\n            </div>\n            <div class=\"modal-footer\">\n                <button class=\"btn btn-secondary\" (click)=\"template.hide()\">\n            Fechar\n           </button>\n                <button class=\"btn btn-primary ml-auto\" [disabled]=\"!registerForm.valid\" (click)=\"salvarAlteracao(template)\">\n              Salvar Alterações \n          </button>\n            </div>\n        </div>\n    </div>\n</div>\n\n<!-- testando validaçoes mostrando os valores e status em formatos json -->\n<!-- <p>Form Value: {{registerForm.value | json}}</p> -->\n<!-- <p>Form status: {{registerForm.status | json}}</p> -->\n\n<div bsModal #confirm=\"bs-modal\" class=\"modal fade\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"dialog-sizes-name1\">\n    <div class=\"modal-dialog modal-sm\">\n        <div class=\"modal-content\">\n            <div class=\"modal-header\">\n                <h4 class=\"modal-title pull-left\">\n                    Deletando Evento\n                </h4>\n                <button type=\"button\" class=\"close pull-right\" (click)=\"confirm.hide()\" aria-label=\"Close\">\n        \t\t\t<span aria-hidden=\"true\">&times;</span>\n      \t\t\t</button>\n            </div>\n            <div class=\"modal-body\">\n                <p>{{bodyDeletarEvento}}</p>\n            </div>\n            <div class=\"modal-footer btn-group d-flex\">\n                <button type=\"button\" class=\"btn btn-outline-primary\" (click)=\"confirm.hide()\">\n        \t\t\tCENCELAR\n      \t\t\t</button>\n                <button type=\"button\" class=\"btn btn-outline-danger\" (click)=\"confirmeDelete(confirm)\">\n          \t\t\tDELETAR\n        \t\t</button>\n            </div>\n        </div>\n    </div>\n</div>\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/evento/eventoEdit/eventoEdit.component.html":
/*!***************************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/evento/eventoEdit/eventoEdit.component.html ***!
  \***************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<app-titulo [title]=\"titulo\"></app-titulo>\n<div [style.width.px]=\"imgArrowWidth\" [style.margin.px]=\"imgArrowMarge\" style=\"cursor: pointer;\">\n    <i class=\"fas fa-arrow-circle-left\" (click)=\"backToGeneralEvents()\"></i>\n</div>\n<form [formGroup]=\"registerForm\">\n    <div class=\"row\">\n        <div class=\"col-md-8\">\n            <tabset>\n                <tab heading=\"Evento\">\n                    <div class=\"form-row\">\n                        <div class=\"form-group col-md-12\">\n                            <label>Tema</label>\n                            <input type=\"text\" class=\"form-control\" [(ngModel)]=\"evento.tema\" [ngClass]=\"{'is-invalid': registerForm.get('tema').errors && registerForm.get('tema').touched}\" formControlName=\"tema\" placeholder=\"Insira o Tema\">\n                            <div *ngIf=\"registerForm.get('tema').hasError('required')\n                                   && registerForm.get('tema').touched\" class=\"invalid-feedback\">\n                                Tema é obrigatório.\n                            </div>\n                            <div *ngIf=\"registerForm.get('tema').hasError('minlength')\n                                  && registerForm.get('tema').touched\" class=\"invalid-feedback\">\n                                Tema deve ter no mínimo 4 Caracters.\n                            </div>\n                            <div *ngIf=\"registerForm.get('tema').hasError('maxlength')\n                                 && registerForm.get('tema').touched\" class=\"invalid-feedback\">\n                                Tema deve ter no máximo 50 Caracters.\n                            </div>\n                        </div>\n                    </div>\n                    <div class=\"form-row\">\n                        <div class=\"form-group col-md-8\">\n                            <label>Local</label>\n                            <input type=\"text\" class=\"form-control\" [(ngModel)]=\"evento.local\" [ngClass]=\"{'is-invalid': registerForm.get('local').errors \n                                    && registerForm.get('local').touched}\" formControlName=\"local\" placeholder=\"Insira o Local\">\n                            <div *ngIf=\"registerForm.get('local').hasError('required')\n                                         && registerForm.get('local').touched\" class=\"invalid-feedback\">\n                                Local é obrigatório.\n                            </div>\n                        </div>\n                        <div class=\"form-group col-md-4\">\n                            <label>Data e Hora</label>\n                            <input type=\"text\" class=\"form-control\" [(ngModel)]=\"evento.dataEvento\" bsDatepicker value=\"{{dataEvento | DateTimeFormatPipe}}\" [bsConfig]=\"{ dateInputFormat : 'DD/MM/YYYY hh:mm' }\" [ngClass]=\"{'is-invalid': registerForm.get('dataEvento').errors \n                                    && registerForm.get('dataEvento').touched}\" formControlName=\"dataEvento\">\n                            <div *ngIf=\"registerForm.get('dataEvento').hasError('required')\n                                    && registerForm.get('dataEvento').touched\" class=\"invalid-feedback\">\n                                Data e hora é obrigatório.\n                            </div>\n                        </div>\n                    </div>\n                    <div class=\"form-row\">\n                        <div class=\"form-group col-md-2\">\n                            <label>Qtd Pessoas</label>\n                            <input type=\"text\" [(ngModel)]=\"evento.qtdPessoas\" [ngClass]=\"{'is-invalid': registerForm.get('qtdPessoas').errors \n                                 && registerForm.get('qtdPessoas').touched}\" class=\"form-control is-invalid\" formControlName=\"qtdPessoas\" placeholder=\"\">\n                            <div *ngIf=\"registerForm.get('qtdPessoas').hasError('required')\n                                && registerForm.get('qtdPessoas').touched\" class=\"invalid-feedback\">\n                                Qtd Pessoas é obrigatório.\n                            </div>\n                            <div *ngIf=\"registerForm.get('qtdPessoas').hasError('max')\n                                && registerForm.get('qtdPessoas').touched\" class=\"invalid-feedback\">\n                                Qtd Pessoas deve ser menor que 120000.\n                            </div>\n                        </div>\n\n                        <div class=\"form-group col-md-4\">\n                            <label>Telefone</label>\n                            <input type=\"text\" mask=\"(00)00000-0000\" class=\"form-control\" [(ngModel)]=\"evento.telefone\" [ngClass]=\"{'is-invalid': registerForm.get('telefone').errors \n                                && registerForm.get('telefone').touched}\" formControlName=\"telefone\" placeholder=\"(00) 90000-0000\">\n                            <div *ngIf=\"registerForm.get('telefone').hasError('required')\n                                && registerForm.get('telefone').touched\" class=\"invalid-feedback\">\n                                Telefone é obrigatório.\n                            </div>\n                        </div>\n                        <div class=\"form-group col-md-6\">\n                            <label>Email</label>\n                            <input type=\"text\" class=\"form-control\" [(ngModel)]=\"evento.email\" [ngClass]=\"{'is-invalid': registerForm.get('email').errors \n                                && registerForm.get('email').touched}\" formControlName=\"email\" placeholder=\"e-mail\">\n                            <div *ngIf=\"registerForm.get('email').hasError('required')\n                                && registerForm.get('email').touched\" class=\"invalid-feedback\">\n                                Email é obrigatório.\n                            </div>\n                            <div *ngIf=\"registerForm.get('email').hasError('email')\n                                && registerForm.get('email').touched\" class=\"invalid-feedback\">\n                                Deve ser um e-mail válido.\n                            </div>\n                        </div>\n                    </div>\n                </tab>\n                <tab heading=\"Lotes\">\n                    <div>\n                        <div formArrayName=\"lotes\" *ngFor=\"let lote of lotes.controls; let i=index\">\n                            <fieldset [formGroupName]=\"i\" class=\"form-group\">\n                                <legend class=\"d-flex justify-content-between capitalize\">\n                                    {{ lotes.get(i+'.nome').value == '' ? 'Lotes' : lotes.get(i+'.nome').value }}\n                                    <button (click)=\"removerLote(i)\" class=\"btn btn-sm btn-warning mb-1\">remove</button>\n                                </legend>\n                                <div class=\"row\">\n                                    <div class=\"form-group col-md-4\">\n                                        <label>Nome</label>\n                                        <input type=\"text\" class=\"form-control\" [ngClass]=\"{'is-invalid': lotes.get(i+'.nome').errors && lotes.get(i+'.nome').touched}\" formControlName=\"nome\" placeholder=\"Lote\">\n                                    </div>\n                                    <div class=\"form-group col-md-4\">\n                                        <label>Quantidade</label>\n                                        <input type=\"text\" class=\"form-control\" [ngClass]=\"{'is-invalid': lotes.get(i+'.quantidade').errors && lotes.get(i+'.quantidade').touched}\" formControlName=\"quantidade\" placeholder=\"000\">\n                                    </div>\n                                    <div class=\"form-group col-md-4\">\n                                        <label>Preço</label>\n                                        <input type=\"text\" currencyMask [options]=\"{ prefix: 'R$ ', thousands: '.', decimal: ',', align: 'left' }\" class=\"form-control\" [ngClass]=\"{'is-invalid': lotes.get(i+'.preco').errors && lotes.get(i+'.preco').touched}\" formControlName=\"preco\" placeholder=\"R$ 0,00\">\n                                    </div>\n                                    <div class=\"form-group col-md-4\">\n                                        <label>Data Início</label>\n                                        <input type=\"text\" class=\"form-control\" formControlName=\"dataInicio\" placeholder=\"01/01/2019\">\n                                    </div>\n                                    <div class=\"form-group col-md-4\">\n                                        <label>Data Fim</label>\n                                        <input type=\"text\" class=\"form-control\" formControlName=\"dataFim\" placeholder=\"01/01/2019\">\n                                    </div>\n\n                                </div>\n                            </fieldset>\n\n                        </div>\n                        <button (click)=\"adicionarLote()\" class=\"btn btn-outline-primary\">\n                           Adicionar Lote\n                       </button>\n                    </div>\n                </tab>\n                <tab heading=\"Redes Sociais\">\n                    <div formArrayName=\"redesSociais\" *ngFor=\"let redeSocial of redesSociais.controls; let j=index\">\n                        <fieldset [formGroupName]=\"j\" class=\"form-group\">\n                            <legend class=\"d-flex justify-content-between capitalize\">\n\n                                {{ redesSociais.get(j+'.nome').value == '' ? 'Redes Sociais' : redesSociais.get(j+'.nome').value?.replace('fab fa-', '') }}\n\n                                <button (click)=\"removerRedeSocial(j)\" class=\"btn btn-sm btn-warning mb-1\">remove</button>\n                            </legend>\n                            <div class=\"row\">\n                                <div class=\"form-group col-md-4\">\n                                    <label>Nome</label>\n                                    <select class=\"form-control\" [ngClass]=\"{'is-invalid': redesSociais.get(j+'.nome').errors && redesSociais.get(j+'.nome').touched}\" formControlName=\"nome\">\n                                  <option value=\"\">Selecione</option>\n                                  <option value=\"fab fa-youtube\">Youtube</option>\n                                  <option value=\"fab fa-instagram\">Instagram</option>\n                                  <option value=\"fab fa-facebook\">Facebook</option>\n                                  <option value=\"fab fa-twitter\">Twitter</option>\n                                  <option value=\"fab fa-google\">Google</option>\n                                  <option value=\"fab fa-linkedin\">Linkedin</option>\n                                  <option value=\"fab fa-pinterest\">Pinterest</option>\n                                  <option value=\"fab fa-whatsapp\">Whatsapp</option>\n                                  <option value=\"fab fa-telegram\">Telegram</option>\n                                  <option value=\"fab fa-skype\">Skype</option>\n                                  <option value=\"fab fa-vimeo\">Vimeo</option>\n                                </select>\n                                </div>\n                                <div class=\"form-group col-md-8\">\n                                    <label>Link</label>\n                                    <input type=\"text\" prefix=\"http://\" mask=\"\" [ngClass]=\"{'is-invalid': redesSociais.get(j+'.url').errors && redesSociais.get(j+'.url').touched}\" formControlName=\"url\" class=\"form-control\" placeholder=\"URL\">\n                                </div>\n                            </div>\n                        </fieldset>\n                    </div>\n                    <button (click)=\"adicionarRedeSocial()\" class=\"btn btn-outline-primary\">\n                        Adicionar Rede Social\n                    </button>\n                </tab>\n            </tabset>\n            <div class=\"row\">\n                <div class=\"col-md-12 d-flex justify-content-end\">\n                    <!-- {{registerForm.value | json}} -->\n                    <button [disabled]=\"!registerForm.valid\" class=\"btn btn-success my-2\" (click)=\"salvarEvento()\">\n                        Salvar Alterações\n                    </button>\n                </div>\n            </div>\n        </div>\n        <div class=\"col-md-4\">\n            <div class=\"form-row\">\n                <div class=\"form-group col-md-9\">\n                    <input type=\"file\" #file (change)=\"onFileChange($event, $event.target.files)\" class=\"form-control is-invalid\" formControlName=\"imagemUrl\" placeholder=\"\" style=\"display: none\">\n                </div>\n            </div>\n            <div class=\"card profile-card-2\">\n                <div class=\"card-img-block\">\n                    <img [src]=\"imagemUrl\"  accept=\"image/png\" class=\"img-fluid\" (click)=\"file.click()\" style=\"cursor: pointer; width: 350px;\" alt=\"Card image cap\" />\n                </div>\n                <div class=\"card-body pt-3\">\n                    <h4>{{evento.tema}}</h4>\n                    <p class=\"card-text\">\n                        <b>Local:</b> {{evento.local}}\n                        <br>\n                        <b>Data:</b> {{evento.dataEvento | DateTimeFormatPipe}}\n                    </p>\n                    <hr>\n                    <p class=\"card-text\">\n                        <b>Contatos</b><br>\n                        <small class=\"text-muted\">Telefone: {{evento.telefone | mask: '(000) 00000-0000'}}</small>\n                        <br>\n                        <small class=\"text-muted\">e-mail: {{evento.email}}</small>\n                    </p>\n                    <p class=\"card-text\">\n                        Capacidade:\n                        <small class=\"text-muted\">{{evento.qtdPessoas}}</small>\n                    </p>\n                    <div class=\"row\">\n                        <div class=\"icon-block col-md-8 iconesSociais\">\n                            <a href=\"{{redesSociais.get(l+'.url').value}}\" *ngFor=\"let redeSocial of redesSociais.controls; let l=index;\" class=\"mr-3\" target=\"_blank\">\n                                <i class=\"{{redesSociais.get(l+'.nome').value}}\"></i>\n                            </a>\n                        </div>\n                        <!--div class=\"col-md-4 d-flex justify-content-center\">  \n              <a href=\"#\" class=\"btn btn-outline-primary\">Participar</a>\n            </div-->\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</form>\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/nav/nav.component.html":
/*!******************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/nav/nav.component.html ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<nav class=\"navbar navbar-expand-md navbar-dark bg-dark\" *ngIf=\"showMenu()\">\n  <div class=\"container\">\n      <a class=\"navbar-brand\" routerLink=\"dashboard\">ProAgil</a>\n      <button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\"#navbarsExampleDefault\" aria-controls=\"navbarsExampleDefault\" aria-expanded=\"false\" aria-label=\"Toggle navigation\">\n    <span class=\"navbar-toggler-icon\"></span>\n  </button>\n\n      <div *ngIf=\"!loggedIn()\" class=\"collapse navbar-collapse\" id=\"navbarsExampleDefault\">\n          <ul class=\"navbar-nav mr-auto\">\n              <li class=\"nav-item\" routerLinkActive=\"active\">\n                  <a class=\"nav-link\" routerLink=\"evento\">Eventos</a>\n              </li>\n              <li class=\"nav-item\" routerLinkActive=\"active\">\n                  <a class=\"nav-link\" routerLink=\"palestrantes\">Palestrantes</a>\n              </li>\n              <li class=\"nav-item\" routerLinkActive=\"active\">\n                  <a class=\"nav-link\" routerLink=\"contatos\">Contatos</a>\n              </li>\n          </ul>\n      </div>\n\n      <ul *ngIf=\"!loggedIn()\" class=\"navbar-nav\">\n          <li class=\"nav-item dropdown\" dropdown>\n              <a dropdownToggle class=\"nav-link dropdown-toggle\" id=\"navbarDropdownMenuLink\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\" style=\"cursor: pointer; text-transform: capitalize;\">\n        {{userName()}}\n      </a>\n              <div *dropdownMenu class=\"dropdown-menu\" aria-labelledby=\"navbarDropdownMenuLink\">\n                  <a class=\"dropdown-item\">\n          Perfil\n        </a>\n                  <div role=\"separator\" class=\"divider\"></div>\n                  <a class=\"dropdown-item\" (click)=\"logout()\" style=\"cursor: pointer\">\n          Sair\n        </a>\n              </div>\n          </li>\n      </ul>\n\n      <button *ngIf=\"loggedIn()\" class=\"btn btn-success\" (click)=\"entrar()\">Entrar</button>\n\n  </div>\n</nav>\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/palestrantes/palestrantes.component.html":
/*!************************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/palestrantes/palestrantes.component.html ***!
  \************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<app-titulo [title]=\"tituloPalestrantes\"></app-titulo>\n<p>\n  palestrantes works!\n</p>\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/shared/titulo/titulo.component.html":
/*!*******************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/shared/titulo/titulo.component.html ***!
  \*******************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<h2>\n  {{ title }}\n</h2>\n<hr>\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/user/login/login.component.html":
/*!***************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/user/login/login.component.html ***!
  \***************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<app-titulo (titulo)=\"titulo\"></app-titulo>\n\n<body class=\"text-center\" data-gr-c-s-loaded=\"true\">\n  <form class=\"form-signin\" #loginForm=\"ngForm\" (ngSubmit)=\"login()\">\n   <!-- <img class=\"mb-4\" src=\"\" alt=\"\" width=\"72\" height=\"72\"> -->\n    <h1 class=\"h3 mb-3 font-weight-normal\">Por favor entre com o seu Login</h1>\n    <label for=\"username\" class=\"sr-only\">Usuário</label>\n    <input type=\"email\" id=\"username\" class=\"form-control\" placeholder=\"Usuário\"\n    name=\"username\" required [(ngModel)]=\"model.username\">\n    <label for=\"password\" class=\"sr-only\">Password</label>\n    <input type=\"password\" id=\"password\" class=\"form-control\" placeholder=\"Senha\"\n    name=\"password\" required [(ngModel)]=\"model.password\">\n    <!--div class=\"checkbox mb-3\">\n      <label>\n        <input type=\"checkbox\" value=\"remember-me\"> Remember me\n      </label>\n    </div-->\n    <button [disabled]=\"!loginForm.valid\" class=\"btn btn-lg btn-primary btn-block\" type=\"submit\">Entrar</button>\n    <p class=\"mt-5 mb-3 text-muted\">Não tem login? Cadastre-se abaixo</p>\n    <button class=\"btn btn-lg btn-link btn-block\" (click)=\"router.navigate(['/user/registration'])\">Quero me cadastrar</button>\n  </form>  \n</body>\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/user/registration/registration.component.html":
/*!*****************************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/user/registration/registration.component.html ***!
  \*****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row mt-4\">\n  <div class=\"col-md-6\" style=\"height: 450px;\">\n    <div class=\"row col-md-12 my-auto side-heder\">\n      <h1>Cadastro de Usuário</h1>\n    </div>\n  </div>\n  <div class=\"col-md-6\">\n    <form [formGroup]=\"registerForm\">\n      <div class=\"form-group required\">\n        <label for=\"\">Nome Completo:</label>\n        <input type=\"text\" class=\"form-control\" formControlName=\"fullName\"\n        [ngClass]=\"{'is-invalid': registerForm.get('fullName').errors &&\n                                  registerForm.get('fullName').touched }\"\n          placeholder=\"Insira o Nome Completo\"/>\n        <div *ngIf=\"registerForm.get('fullName').hasError('required') &&\n                    registerForm.get('fullName').touched\"\n          class=\"invalid-feedback\">\n          Nome Completo é obrigatório.\n        </div>\n      </div>\n      <div class=\"form-group\">\n        <label for=\"\">Email:</label>\n        <input class=\"form-control\" type=\"text\" formControlName=\"email\"\n          [ngClass]=\"{ 'is-invalid': registerForm.get('email').errors && \n                                     registerForm.get('email').touched}\"\n          placeholder=\"Insira o Nome Completo\"/>\n        <div *ngIf=\"registerForm.get('email').hasError('required') &&\n                    registerForm.get('email').touched\"\n          class=\"invalid-feedback\">\n          email é obrigatório.\n        </div>\n        \n        <div *ngIf=\"registerForm.get('email').hasError('email')\n        && registerForm.get('email').touched\" class=\"invalid-feedback\">\n          Deve ser um e-mail válido.\n        </div>\n\n      </div>\n      <div class=\"form-group\">\n        <label for=\"\">Usuario:</label>\n        <input class=\"form-control\" type=\"text\" formControlName=\"userName\"\n          [ngClass]=\"{'is-invalid': registerForm.get('userName').errors &&\n                                    registerForm.get('userName').touched}\"\n          placeholder=\"Insira o nome de Usuário\"/>\n        <div *ngIf=\"registerForm.get('userName').hasError('required') &&\n                    registerForm.get('userName').touched\"\n          class=\"invalid-feedback\">\n          Usuário é obrigatório.\n        </div>\n      </div>\n      <div formGroupName=\"passwords\">\n        <div class=\"form-group\">\n          <label for=\"\">Senha:</label>\n          <input class=\"form-control\" type=\"password\" formControlName=\"password\"\n            [ngClass]=\"{ 'is-invalid': registerForm.get('passwords.password').errors &&\n                                       registerForm.get('passwords.password').touched}\"\n            placeholder=\"Digite uma Senha\" />\n            <div *ngIf=\"registerForm.get('passwords.password').hasError('minlength') &&\n            registerForm.get('passwords.password').touched\"\n            class=\"invalid-feedback\">\n            Deve conter no mínimo 4 caracters\n          </div>\n          <div *ngIf=\"registerForm.get('passwords.password').hasError('required') &&\n                      registerForm.get('passwords.password').touched\"\n            class=\"invalid-feedback\">\n            Senha é obrigatório.\n          </div>\n        </div>\n        <div class=\"form-group\">\n          <label for=\"\">Confirmar Senha:</label>\n          <input class=\"form-control\" type=\"password\" formControlName=\"confirmPassword\"\n            [ngClass]=\"{ 'is-invalid': registerForm.get('passwords.confirmPassword').errors \n                         && registerForm.get('passwords.confirmPassword').touched \n                         || registerForm.get('passwords.confirmPassword').hasError('mismatch') \n                         && registerForm.get('passwords.confirmPassword').touched }\"\n            placeholder=\"Confirme a Senha\" />\n          <div *ngIf=\"registerForm.get('passwords.confirmPassword').hasError('required') &&\n                      registerForm.get('passwords.confirmPassword').touched\"\n            class=\"invalid-feedback\">\n            Confirme a Senha\n          </div>\n          <div *ngIf=\"registerForm.get('passwords.confirmPassword').hasError('mismatch') \n                      && registerForm.get('passwords.confirmPassword').touched\"\n            class=\"invalid-feedback\">\n            Confirmação não confere\n          </div>\n        </div>\n      </div>\n      <div class=\"form-row\">\n        <div class=\"form-group col-md-8 offset-md-2\">\n          <button class=\"btn btn-lg btn-success btn-block\" (click)=\"cadastrarUsuario()\">Registar</button>\n        </div>\n      </div>\n    </form>\n  </div>\n</div>\n"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/user/user.component.html":
/*!********************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/user/user.component.html ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"container\">\n  <div class=\"col-md-8 offset-md-2\">\n     <router-outlet></router-outlet>\n  </div>\n</div>\n"

/***/ }),

/***/ "./src/app/_helps/DateTimeFormatPipe.pipe.ts":
/*!***************************************************!*\
  !*** ./src/app/_helps/DateTimeFormatPipe.pipe.ts ***!
  \***************************************************/
/*! exports provided: DateTimeFormatPipePipe */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DateTimeFormatPipePipe", function() { return DateTimeFormatPipePipe; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm2015/common.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _util_Constants__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../util/Constants */ "./src/app/util/Constants.ts");




let DateTimeFormatPipePipe = class DateTimeFormatPipePipe extends _angular_common__WEBPACK_IMPORTED_MODULE_1__["DatePipe"] {
    transform(value, args) {
        return super.transform(value, _util_Constants__WEBPACK_IMPORTED_MODULE_3__["Constants"].DATE_TIME_FMT);
    }
};
DateTimeFormatPipePipe = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["Pipe"])({
        name: 'DateTimeFormatPipe'
    })
], DateTimeFormatPipePipe);



/***/ }),

/***/ "./src/app/app-routing.module.ts":
/*!***************************************!*\
  !*** ./src/app/app-routing.module.ts ***!
  \***************************************/
/*! exports provided: AppRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function() { return AppRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm2015/common.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _auth_auth_guard__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./auth/auth.guard */ "./src/app/auth/auth.guard.ts");
/* harmony import */ var _contatos_contatos_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./contatos/contatos.component */ "./src/app/contatos/contatos.component.ts");
/* harmony import */ var _dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./dashboard/dashboard.component */ "./src/app/dashboard/dashboard.component.ts");
/* harmony import */ var _evento_evento_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./evento/evento.component */ "./src/app/evento/evento.component.ts");
/* harmony import */ var _evento_eventoEdit_eventoEdit_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./evento/eventoEdit/eventoEdit.component */ "./src/app/evento/eventoEdit/eventoEdit.component.ts");
/* harmony import */ var _palestrantes_palestrantes_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./palestrantes/palestrantes.component */ "./src/app/palestrantes/palestrantes.component.ts");
/* harmony import */ var _user_login_login_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./user/login/login.component */ "./src/app/user/login/login.component.ts");
/* harmony import */ var _user_registration_registration_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./user/registration/registration.component */ "./src/app/user/registration/registration.component.ts");
/* harmony import */ var _user_user_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./user/user.component */ "./src/app/user/user.component.ts");













const routes = [
    { path: 'user', component: _user_user_component__WEBPACK_IMPORTED_MODULE_12__["UserComponent"],
        children: [
            { path: 'login', component: _user_login_login_component__WEBPACK_IMPORTED_MODULE_10__["LoginComponent"] },
            { path: 'registration', component: _user_registration_registration_component__WEBPACK_IMPORTED_MODULE_11__["RegistrationComponent"] }
        ]
    },
    { path: 'evento', component: _evento_evento_component__WEBPACK_IMPORTED_MODULE_7__["EventoComponent"], canActivate: [_auth_auth_guard__WEBPACK_IMPORTED_MODULE_4__["AuthGuard"]] },
    { path: 'evento/:id/edit', component: _evento_eventoEdit_eventoEdit_component__WEBPACK_IMPORTED_MODULE_8__["EventoEditComponent"], canActivate: [_auth_auth_guard__WEBPACK_IMPORTED_MODULE_4__["AuthGuard"]] },
    { path: 'palestrantes', component: _palestrantes_palestrantes_component__WEBPACK_IMPORTED_MODULE_9__["PalestrantesComponent"], canActivate: [_auth_auth_guard__WEBPACK_IMPORTED_MODULE_4__["AuthGuard"]] },
    { path: 'dashboard', component: _dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_6__["DashboardComponent"], canActivate: [_auth_auth_guard__WEBPACK_IMPORTED_MODULE_4__["AuthGuard"]] },
    { path: 'contatos', component: _contatos_contatos_component__WEBPACK_IMPORTED_MODULE_5__["ContatosComponent"], canActivate: [_auth_auth_guard__WEBPACK_IMPORTED_MODULE_4__["AuthGuard"]] },
    { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
    { path: '**', redirectTo: 'dashboard', pathMatch: 'full' }
];
let AppRoutingModule = class AppRoutingModule {
};
AppRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
        declarations: [],
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_1__["CommonModule"],
            _angular_router__WEBPACK_IMPORTED_MODULE_3__["RouterModule"].forRoot(routes)
        ],
        exports: [_angular_router__WEBPACK_IMPORTED_MODULE_3__["RouterModule"]]
    })
], AppRoutingModule);



/***/ }),

/***/ "./src/app/app.component.css":
/*!***********************************!*\
  !*** ./src/app/app.component.css ***!
  \***********************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FwcC5jb21wb25lbnQuY3NzIn0= */"

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let AppComponent = class AppComponent {
    constructor() {
        this.title = 'ProAgil-App';
    }
};
AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-root',
        template: __webpack_require__(/*! raw-loader!./app.component.html */ "./node_modules/raw-loader/index.js!./src/app/app.component.html"),
        styles: [__webpack_require__(/*! ./app.component.css */ "./src/app/app.component.css")]
    })
], AppComponent);



/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm2015/platform-browser.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var ngx_bootstrap_dropdown__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ngx-bootstrap/dropdown */ "./node_modules/ngx-bootstrap/dropdown/fesm2015/ngx-bootstrap-dropdown.js");
/* harmony import */ var ngx_bootstrap_tooltip__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ngx-bootstrap/tooltip */ "./node_modules/ngx-bootstrap/tooltip/fesm2015/ngx-bootstrap-tooltip.js");
/* harmony import */ var ngx_bootstrap_modal__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ngx-bootstrap/modal */ "./node_modules/ngx-bootstrap/modal/fesm2015/ngx-bootstrap-modal.js");
/* harmony import */ var ngx_bootstrap_datepicker__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ngx-bootstrap/datepicker */ "./node_modules/ngx-bootstrap/datepicker/fesm2015/ngx-bootstrap-datepicker.js");
/* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @angular/platform-browser/animations */ "./node_modules/@angular/platform-browser/fesm2015/animations.js");
/* harmony import */ var ngx_toastr__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ngx-toastr */ "./node_modules/ngx-toastr/fesm2015/ngx-toastr.js");
/* harmony import */ var ngx_mask__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ngx-mask */ "./node_modules/ngx-mask/fesm2015/ngx-mask.js");
/* harmony import */ var ngx_currency__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ngx-currency */ "./node_modules/ngx-currency/fesm2015/ngx-currency.js");
/* harmony import */ var ngx_bootstrap_tabs__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ngx-bootstrap/tabs */ "./node_modules/ngx-bootstrap/tabs/fesm2015/ngx-bootstrap-tabs.js");
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./app-routing.module */ "./src/app/app-routing.module.ts");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var _shared_titulo_titulo_component__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! ./shared/titulo/titulo.component */ "./src/app/shared/titulo/titulo.component.ts");
/* harmony import */ var _evento_evento_component__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! ./evento/evento.component */ "./src/app/evento/evento.component.ts");
/* harmony import */ var _contatos_contatos_component__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! ./contatos/contatos.component */ "./src/app/contatos/contatos.component.ts");
/* harmony import */ var _dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! ./dashboard/dashboard.component */ "./src/app/dashboard/dashboard.component.ts");
/* harmony import */ var _nav_nav_component__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! ./nav/nav.component */ "./src/app/nav/nav.component.ts");
/* harmony import */ var _palestrantes_palestrantes_component__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! ./palestrantes/palestrantes.component */ "./src/app/palestrantes/palestrantes.component.ts");
/* harmony import */ var _user_user_component__WEBPACK_IMPORTED_MODULE_22__ = __webpack_require__(/*! ./user/user.component */ "./src/app/user/user.component.ts");
/* harmony import */ var _user_login_login_component__WEBPACK_IMPORTED_MODULE_23__ = __webpack_require__(/*! ./user/login/login.component */ "./src/app/user/login/login.component.ts");
/* harmony import */ var _user_registration_registration_component__WEBPACK_IMPORTED_MODULE_24__ = __webpack_require__(/*! ./user/registration/registration.component */ "./src/app/user/registration/registration.component.ts");
/* harmony import */ var _evento_eventoEdit_eventoEdit_component__WEBPACK_IMPORTED_MODULE_25__ = __webpack_require__(/*! ./evento/eventoEdit/eventoEdit.component */ "./src/app/evento/eventoEdit/eventoEdit.component.ts");
/* harmony import */ var _services_evento_service__WEBPACK_IMPORTED_MODULE_26__ = __webpack_require__(/*! ./services/evento.service */ "./src/app/services/evento.service.ts");
/* harmony import */ var _auth_auth_interceptor__WEBPACK_IMPORTED_MODULE_27__ = __webpack_require__(/*! ./auth/auth.interceptor */ "./src/app/auth/auth.interceptor.ts");
/* harmony import */ var _helps_DateTimeFormatPipe_pipe__WEBPACK_IMPORTED_MODULE_28__ = __webpack_require__(/*! ./_helps/DateTimeFormatPipe.pipe */ "./src/app/_helps/DateTimeFormatPipe.pipe.ts");
/* harmony import */ var _services_auth_service__WEBPACK_IMPORTED_MODULE_29__ = __webpack_require__(/*! ./services/auth.service */ "./src/app/services/auth.service.ts");

// node packages managers













// components, services, auth, pipes, etc
















const maskConfig = () => {
    return {
        validation: false,
    };
};
let AppModule = class AppModule {
};
AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
        declarations: [
            _app_component__WEBPACK_IMPORTED_MODULE_15__["AppComponent"],
            _evento_evento_component__WEBPACK_IMPORTED_MODULE_17__["EventoComponent"],
            _evento_eventoEdit_eventoEdit_component__WEBPACK_IMPORTED_MODULE_25__["EventoEditComponent"],
            _nav_nav_component__WEBPACK_IMPORTED_MODULE_20__["NavComponent"],
            _helps_DateTimeFormatPipe_pipe__WEBPACK_IMPORTED_MODULE_28__["DateTimeFormatPipePipe"],
            _dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_19__["DashboardComponent"],
            _contatos_contatos_component__WEBPACK_IMPORTED_MODULE_18__["ContatosComponent"],
            _palestrantes_palestrantes_component__WEBPACK_IMPORTED_MODULE_21__["PalestrantesComponent"],
            _shared_titulo_titulo_component__WEBPACK_IMPORTED_MODULE_16__["TituloComponent"],
            _user_user_component__WEBPACK_IMPORTED_MODULE_22__["UserComponent"],
            _user_login_login_component__WEBPACK_IMPORTED_MODULE_23__["LoginComponent"],
            _user_registration_registration_component__WEBPACK_IMPORTED_MODULE_24__["RegistrationComponent"]
        ],
        imports: [
            _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"],
            _app_routing_module__WEBPACK_IMPORTED_MODULE_14__["AppRoutingModule"],
            _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"],
            ngx_bootstrap_dropdown__WEBPACK_IMPORTED_MODULE_5__["BsDropdownModule"].forRoot(),
            ngx_bootstrap_datepicker__WEBPACK_IMPORTED_MODULE_8__["BsDatepickerModule"].forRoot(),
            ngx_bootstrap_tooltip__WEBPACK_IMPORTED_MODULE_6__["TooltipModule"].forRoot(),
            ngx_bootstrap_modal__WEBPACK_IMPORTED_MODULE_7__["ModalModule"].forRoot(),
            ngx_toastr__WEBPACK_IMPORTED_MODULE_10__["ToastrModule"].forRoot({
                timeOut: 2000,
                positionClass: 'toast-top-right',
                preventDuplicates: true,
            }),
            _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_9__["BrowserAnimationsModule"],
            _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpClientModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_4__["FormsModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_4__["ReactiveFormsModule"],
            _app_routing_module__WEBPACK_IMPORTED_MODULE_14__["AppRoutingModule"],
            ngx_mask__WEBPACK_IMPORTED_MODULE_11__["NgxMaskModule"].forRoot(maskConfig),
            ngx_bootstrap_tabs__WEBPACK_IMPORTED_MODULE_13__["TabsModule"].forRoot(),
            ngx_currency__WEBPACK_IMPORTED_MODULE_12__["NgxCurrencyModule"]
        ],
        providers: [
            _services_auth_service__WEBPACK_IMPORTED_MODULE_29__["AuthService"],
            _services_evento_service__WEBPACK_IMPORTED_MODULE_26__["EventoService"],
            {
                provide: _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HTTP_INTERCEPTORS"],
                useClass: _auth_auth_interceptor__WEBPACK_IMPORTED_MODULE_27__["AuthInterceptor"],
                multi: true // permite multiplas requisiçoes
            }
        ],
        bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_15__["AppComponent"]]
    })
], AppModule);



/***/ }),

/***/ "./src/app/auth/auth.guard.ts":
/*!************************************!*\
  !*** ./src/app/auth/auth.guard.ts ***!
  \************************************/
/*! exports provided: AuthGuard */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthGuard", function() { return AuthGuard; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");



let AuthGuard = class AuthGuard {
    constructor(router) {
        this.router = router;
    }
    canActivate(next, state) {
        // verifica se existe um token
        if (localStorage.getItem('token') !== null) {
            return true;
        }
        else {
            this.router.navigate(['user/login/']); // redireciona para a pagina de login
            return false;
        }
    }
};
AuthGuard.ctorParameters = () => [
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] }
];
AuthGuard = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"]])
], AuthGuard);



/***/ }),

/***/ "./src/app/auth/auth.interceptor.ts":
/*!******************************************!*\
  !*** ./src/app/auth/auth.interceptor.ts ***!
  \******************************************/
/*! exports provided: AuthInterceptor */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthInterceptor", function() { return AuthInterceptor; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var rxjs_internal_operators_tap__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs/internal/operators/tap */ "./node_modules/rxjs/internal/operators/tap.js");
/* harmony import */ var rxjs_internal_operators_tap__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(rxjs_internal_operators_tap__WEBPACK_IMPORTED_MODULE_3__);




let AuthInterceptor = class AuthInterceptor {
    constructor(router) {
        this.router = router;
    }
    intercept(req, next) {
        // throw new Error('Method not implemented.');
        if (localStorage.getItem('token') !== null) {
            const cloneReq = req.clone({
                headers: req.headers.set('Authorization', `Bearer ${localStorage.getItem('token')}`)
            });
            return next.handle(cloneReq).pipe(Object(rxjs_internal_operators_tap__WEBPACK_IMPORTED_MODULE_3__["tap"])((success) => { }, (error) => {
                if (error.status === 401) {
                    this.router.navigateByUrl('user/login');
                }
            }));
        }
        else {
            return next.handle(req.clone());
        }
    }
};
AuthInterceptor.ctorParameters = () => [
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] }
];
AuthInterceptor = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"]])
], AuthInterceptor);



/***/ }),

/***/ "./src/app/contatos/contatos.component.css":
/*!*************************************************!*\
  !*** ./src/app/contatos/contatos.component.css ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2NvbnRhdG9zL2NvbnRhdG9zLmNvbXBvbmVudC5jc3MifQ== */"

/***/ }),

/***/ "./src/app/contatos/contatos.component.ts":
/*!************************************************!*\
  !*** ./src/app/contatos/contatos.component.ts ***!
  \************************************************/
/*! exports provided: ContatosComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ContatosComponent", function() { return ContatosComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let ContatosComponent = class ContatosComponent {
    constructor() {
        this.tituloContatos = 'Contatos';
    }
    ngOnInit() {
    }
};
ContatosComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-contatos',
        template: __webpack_require__(/*! raw-loader!./contatos.component.html */ "./node_modules/raw-loader/index.js!./src/app/contatos/contatos.component.html"),
        styles: [__webpack_require__(/*! ./contatos.component.css */ "./src/app/contatos/contatos.component.css")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
], ContatosComponent);



/***/ }),

/***/ "./src/app/dashboard/dashboard.component.css":
/*!***************************************************!*\
  !*** ./src/app/dashboard/dashboard.component.css ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "section {\r\n    padding-top: 4rem;\r\n    padding-bottom: 5rem;\r\n    background-color: #f1f4fa;\r\n}\r\n.wrap {\r\n    display: flex;\r\n    background: white;\r\n    padding: 1rem 1rem 1rem 1rem;\r\n    border-radius: 0.5rem;\r\n    box-shadow: 7px 7px 30px -5px rgba(0,0,0,0.1);\r\n    margin-bottom: 2rem;\r\n}\r\n.wrap:hover {\r\n    background: linear-gradient(135deg,#6394ff 0%,#0a193b 100%);\r\n    color: white;\r\n}\r\n.ico-wrap {\r\n    margin: auto;\r\n}\r\n.mbr-iconfont {\r\n    font-size: 4.5rem !important;\r\n    color: #313131;\r\n    margin: 1rem;\r\n    padding-right: 1rem;\r\n}\r\n.vcenter {\r\n    margin: auto;\r\n}\r\n.mbr-section-title3 {\r\n    text-align: left;\r\n}\r\nh2 {\r\n    margin-top: 0.5rem;\r\n    margin-bottom: 0.5rem;\r\n}\r\n.display-5 {\r\n    font-family: 'Source Sans Pro',sans-serif;\r\n    font-size: 1.4rem;\r\n}\r\n.mbr-bold {\r\n    font-weight: 700;\r\n}\r\np {\r\n    padding-top: 0.5rem;\r\n    padding-bottom: 0.5rem;\r\n    line-height: 25px;\r\n}\r\n.display-6 {\r\n    font-family: 'Source Sans Pro',sans-serif;\r\n    font-size: 1re}\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvZGFzaGJvYXJkL2Rhc2hib2FyZC5jb21wb25lbnQuY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0lBQ0ksaUJBQWlCO0lBQ2pCLG9CQUFvQjtJQUNwQix5QkFBeUI7QUFDN0I7QUFDQTtJQUNJLGFBQWE7SUFDYixpQkFBaUI7SUFDakIsNEJBQTRCO0lBQzVCLHFCQUFxQjtJQUNyQiw2Q0FBNkM7SUFDN0MsbUJBQW1CO0FBQ3ZCO0FBRUE7SUFDSSwyREFBMkQ7SUFDM0QsWUFBWTtBQUNoQjtBQUVBO0lBQ0ksWUFBWTtBQUNoQjtBQUVBO0lBQ0ksNEJBQTRCO0lBQzVCLGNBQWM7SUFDZCxZQUFZO0lBQ1osbUJBQW1CO0FBQ3ZCO0FBQ0E7SUFDSSxZQUFZO0FBQ2hCO0FBRUE7SUFDSSxnQkFBZ0I7QUFDcEI7QUFDQTtJQUNJLGtCQUFrQjtJQUNsQixxQkFBcUI7QUFDekI7QUFDQTtJQUNJLHlDQUF5QztJQUN6QyxpQkFBaUI7QUFDckI7QUFDQTtJQUNJLGdCQUFnQjtBQUNwQjtBQUVDO0lBQ0csbUJBQW1CO0lBQ25CLHNCQUFzQjtJQUN0QixpQkFBaUI7QUFDckI7QUFDQTtJQUNJLHlDQUF5QztJQUN6QyxjQUFjIiwiZmlsZSI6InNyYy9hcHAvZGFzaGJvYXJkL2Rhc2hib2FyZC5jb21wb25lbnQuY3NzIiwic291cmNlc0NvbnRlbnQiOlsic2VjdGlvbiB7XHJcbiAgICBwYWRkaW5nLXRvcDogNHJlbTtcclxuICAgIHBhZGRpbmctYm90dG9tOiA1cmVtO1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogI2YxZjRmYTtcclxufVxyXG4ud3JhcCB7XHJcbiAgICBkaXNwbGF5OiBmbGV4O1xyXG4gICAgYmFja2dyb3VuZDogd2hpdGU7XHJcbiAgICBwYWRkaW5nOiAxcmVtIDFyZW0gMXJlbSAxcmVtO1xyXG4gICAgYm9yZGVyLXJhZGl1czogMC41cmVtO1xyXG4gICAgYm94LXNoYWRvdzogN3B4IDdweCAzMHB4IC01cHggcmdiYSgwLDAsMCwwLjEpO1xyXG4gICAgbWFyZ2luLWJvdHRvbTogMnJlbTtcclxufVxyXG5cclxuLndyYXA6aG92ZXIge1xyXG4gICAgYmFja2dyb3VuZDogbGluZWFyLWdyYWRpZW50KDEzNWRlZywjNjM5NGZmIDAlLCMwYTE5M2IgMTAwJSk7XHJcbiAgICBjb2xvcjogd2hpdGU7XHJcbn1cclxuXHJcbi5pY28td3JhcCB7XHJcbiAgICBtYXJnaW46IGF1dG87XHJcbn1cclxuXHJcbi5tYnItaWNvbmZvbnQge1xyXG4gICAgZm9udC1zaXplOiA0LjVyZW0gIWltcG9ydGFudDtcclxuICAgIGNvbG9yOiAjMzEzMTMxO1xyXG4gICAgbWFyZ2luOiAxcmVtO1xyXG4gICAgcGFkZGluZy1yaWdodDogMXJlbTtcclxufVxyXG4udmNlbnRlciB7XHJcbiAgICBtYXJnaW46IGF1dG87XHJcbn1cclxuXHJcbi5tYnItc2VjdGlvbi10aXRsZTMge1xyXG4gICAgdGV4dC1hbGlnbjogbGVmdDtcclxufVxyXG5oMiB7XHJcbiAgICBtYXJnaW4tdG9wOiAwLjVyZW07XHJcbiAgICBtYXJnaW4tYm90dG9tOiAwLjVyZW07XHJcbn1cclxuLmRpc3BsYXktNSB7XHJcbiAgICBmb250LWZhbWlseTogJ1NvdXJjZSBTYW5zIFBybycsc2Fucy1zZXJpZjtcclxuICAgIGZvbnQtc2l6ZTogMS40cmVtO1xyXG59XHJcbi5tYnItYm9sZCB7XHJcbiAgICBmb250LXdlaWdodDogNzAwO1xyXG59XHJcblxyXG4gcCB7XHJcbiAgICBwYWRkaW5nLXRvcDogMC41cmVtO1xyXG4gICAgcGFkZGluZy1ib3R0b206IDAuNXJlbTtcclxuICAgIGxpbmUtaGVpZ2h0OiAyNXB4O1xyXG59XHJcbi5kaXNwbGF5LTYge1xyXG4gICAgZm9udC1mYW1pbHk6ICdTb3VyY2UgU2FucyBQcm8nLHNhbnMtc2VyaWY7XHJcbiAgICBmb250LXNpemU6IDFyZX0iXX0= */"

/***/ }),

/***/ "./src/app/dashboard/dashboard.component.ts":
/*!**************************************************!*\
  !*** ./src/app/dashboard/dashboard.component.ts ***!
  \**************************************************/
/*! exports provided: DashboardComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DashboardComponent", function() { return DashboardComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let DashboardComponent = class DashboardComponent {
    constructor() { }
    ngOnInit() {
    }
};
DashboardComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-dashboard',
        template: __webpack_require__(/*! raw-loader!./dashboard.component.html */ "./node_modules/raw-loader/index.js!./src/app/dashboard/dashboard.component.html"),
        styles: [__webpack_require__(/*! ./dashboard.component.css */ "./src/app/dashboard/dashboard.component.css")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
], DashboardComponent);



/***/ }),

/***/ "./src/app/evento/evento.component.css":
/*!*********************************************!*\
  !*** ./src/app/evento/evento.component.css ***!
  \*********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2V2ZW50by9ldmVudG8uY29tcG9uZW50LmNzcyJ9 */"

/***/ }),

/***/ "./src/app/evento/evento.component.ts":
/*!********************************************!*\
  !*** ./src/app/evento/evento.component.ts ***!
  \********************************************/
/*! exports provided: EventoComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EventoComponent", function() { return EventoComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var ngx_bootstrap_chronos__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ngx-bootstrap/chronos */ "./node_modules/ngx-bootstrap/chronos/fesm2015/ngx-bootstrap-chronos.js");
/* harmony import */ var ngx_bootstrap_datepicker__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ngx-bootstrap/datepicker */ "./node_modules/ngx-bootstrap/datepicker/fesm2015/ngx-bootstrap-datepicker.js");
/* harmony import */ var ngx_bootstrap_modal__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ngx-bootstrap/modal */ "./node_modules/ngx-bootstrap/modal/fesm2015/ngx-bootstrap-modal.js");
/* harmony import */ var ngx_toastr__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ngx-toastr */ "./node_modules/ngx-toastr/fesm2015/ngx-toastr.js");
/* harmony import */ var _services_evento_service__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../services/evento.service */ "./src/app/services/evento.service.ts");








Object(ngx_bootstrap_chronos__WEBPACK_IMPORTED_MODULE_3__["defineLocale"])('pt-br', ngx_bootstrap_chronos__WEBPACK_IMPORTED_MODULE_3__["ptBrLocale"]);
// BsLocaleService, ptBrLocale
let EventoComponent = class EventoComponent {
    constructor(toastr, eventoService, modalService, fb, localeService) {
        this.toastr = toastr;
        this.eventoService = eventoService;
        this.modalService = modalService;
        this.fb = fb;
        this.localeService = localeService;
        this.tituloEvento = 'Eventos';
        this.imagemLargura = 50; // variavel de largura da imagem
        this.imagemMargem = 2; // variavel de margem da imagem
        this.mostrarImagem = false;
        this.bodyDeletarEvento = '';
        this._filtroLista = ''; // propriedade de filtro da lista
        this.localeService.use('pt-br');
    }
    // encapsulamento da propriedade _filtroLista
    get filtroLista() {
        return this._filtroLista;
    }
    set filtroLista(value) {
        this._filtroLista = value;
        this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
        // vai receber a filtragem do item ou todos os itens
    }
    editarEvento(evento, template) {
        this.modoSalvar = 'put';
        this.openModal(template); // abre o modal
        this.evento = Object.assign({}, evento); // copia as informaçoes
        this.fileNameToUpdate = evento.imagemUrl.toString();
        this.evento.imagemUrl = '';
        this.registerForm.patchValue(this.evento);
    }
    novoEvento(template) {
        this.modoSalvar = 'post';
        this.openModal(template);
    }
    // excluir Evento
    excluirEvento(evento, template) {
        this.openModal(template);
        this.evento = evento;
        this.bodyDeletarEvento = `Tem certeza que deseja excluir o Evento: ${evento.tema}, Código: ${evento.id}`;
    }
    confirmeDelete(template) {
        this.eventoService.deleteEvento(this.evento.id).subscribe(() => {
            template.hide();
            this.getEventos();
            this.toastr.success('Deletado com sucesso!');
        }, error => {
            this.toastr.error(`Erro ao deletar: ${error}`);
            // console.log(error);
        });
    }
    openModal(template) {
        // this.modalRef = this.modalService.show(template)
        this.registerForm.reset();
        template.show();
    }
    ngOnInit() {
        this.validation();
        this.getEventos();
    }
    filtrarEventos(filtrarPor) {
        // vai retornar os itens em cada filtragem
        filtrarPor = filtrarPor.toLocaleLowerCase();
        return this.eventos.filter((evento) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1);
    }
    alternarImagem() {
        this.mostrarImagem = !this.mostrarImagem; // vai fazer com que as imagens suma da tela
    }
    validation() {
        this.registerForm = this.fb.group({
            // validaçoes dos campos
            tema: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].minLength(4), _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].maxLength(50)]),
            local: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].maxLength(30)]),
            dataEvento: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required),
            qtdPessoas: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].max(300)]),
            imagemUrl: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required),
            telefone: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required),
            email: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].email])
        });
        // console.log(this.registerForm);
    }
    onFileChange(event) {
        const reader = new FileReader(); // vai ler a imagem selecionada
        if (event.target.files && event.target.files.length) {
            this.file = event.target.files;
            console.log(this.file);
        }
    }
    uploadImagem() {
        if (this.modoSalvar === 'post') {
            const nomeArquivo = this.evento.imagemUrl.split('\\', 3);
            this.evento.imagemUrl = nomeArquivo[2]; // [0] = c:/ [1] = folder [2] = nomearquivo
            this.eventoService.postUpload(this.file, nomeArquivo[2]).subscribe(() => {
                this.dataAtual = new Date().getMilliseconds().toString();
                this.getEventos(); // recarrega a pagina automaticamente
            });
        }
        else {
            this.evento.imagemUrl = this.fileNameToUpdate; // mantem o nome na imagem
            this.eventoService.postUpload(this.file, this.fileNameToUpdate).subscribe(() => {
                this.dataAtual = new Date().getMilliseconds().toString();
            });
        }
    }
    // salva as alteraçoes apos inserir novos registros na base de dados
    salvarAlteracao(template) {
        // verificaçao se o formulário está válidado
        if (this.registerForm.valid) {
            if (this.modoSalvar === 'post') {
                this.evento = Object.assign({}, this.registerForm.value); // vai copiar todos os valores do formulário
                this.uploadImagem();
                this.eventoService.postEvento(this.evento).subscribe((novoEvento) => {
                    console.log(novoEvento);
                    template.hide();
                    this.getEventos(); // vai atualizar com os novos eventos inseridos
                    this.toastr.success('Inserido com sucesso!');
                }, (error) => {
                    this.toastr.error(`Erro ao inserir: ${error}`);
                    // console.log(error);
                });
            }
            else {
                this.evento = Object.assign({ id: this.evento.id }, this.registerForm.value); // vai copiar todos os valores do formulário
                this.uploadImagem();
                this.eventoService.putEvento(this.evento).subscribe((novoEvento) => {
                    console.log(novoEvento);
                    template.hide();
                    this.getEventos(); // vai atualizar com os novos eventos inseridos
                    this.toastr.success('Editado com sucesso!');
                }, (error) => {
                    this.toastr.error(`Erro ao editar: ${error}`);
                    // console.log(error);
                });
            }
        }
    }
    getEventos() {
        this.dataAtual = new Date().getMilliseconds().toString();
        /* this.eventos = this.http.get('http://localhost:5000/api/values'); */
        this.dataAtual = new Date().getMilliseconds().toString();
        this.eventoService.getAllEvento().subscribe((eventos) => {
            this.eventos = eventos;
            this.eventosFiltrados = this.eventos;
            console.log(eventos);
        }, error => {
            console.log(error);
        });
    }
};
EventoComponent.ctorParameters = () => [
    { type: ngx_toastr__WEBPACK_IMPORTED_MODULE_6__["ToastrService"] },
    { type: _services_evento_service__WEBPACK_IMPORTED_MODULE_7__["EventoService"] },
    { type: ngx_bootstrap_modal__WEBPACK_IMPORTED_MODULE_5__["BsModalService"] },
    { type: _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormBuilder"] },
    { type: ngx_bootstrap_datepicker__WEBPACK_IMPORTED_MODULE_4__["BsLocaleService"] }
];
EventoComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-evento',
        template: __webpack_require__(/*! raw-loader!./evento.component.html */ "./node_modules/raw-loader/index.js!./src/app/evento/evento.component.html"),
        styles: [__webpack_require__(/*! ./evento.component.css */ "./src/app/evento/evento.component.css")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [ngx_toastr__WEBPACK_IMPORTED_MODULE_6__["ToastrService"],
        _services_evento_service__WEBPACK_IMPORTED_MODULE_7__["EventoService"],
        ngx_bootstrap_modal__WEBPACK_IMPORTED_MODULE_5__["BsModalService"],
        _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormBuilder"],
        ngx_bootstrap_datepicker__WEBPACK_IMPORTED_MODULE_4__["BsLocaleService"]])
], EventoComponent);



/***/ }),

/***/ "./src/app/evento/eventoEdit/eventoEdit.component.css":
/*!************************************************************!*\
  !*** ./src/app/evento/eventoEdit/eventoEdit.component.css ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "i {\r\n    font-size: 25px;\r\n}\r\n\r\n.iconesSociais a {\r\n    color: rgb(94, 94, 94);\r\n}\r\n\r\n.capitalize {\r\n    text-transform: capitalize;\r\n    border-bottom: 1px solid silver;\r\n}\r\n\r\n.tab-pane {\r\n    padding: 20px 8px 8px;\r\n    border-top: 0px;\r\n    border-right: 1px solid #dee2e6;\r\n    border-bottom: 1px solid #dee2e6;\r\n    border-left: 1px solid #dee2e6;\r\n}\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvZXZlbnRvL2V2ZW50b0VkaXQvZXZlbnRvRWRpdC5jb21wb25lbnQuY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0lBQ0ksZUFBZTtBQUNuQjs7QUFFQTtJQUNJLHNCQUFzQjtBQUMxQjs7QUFFQTtJQUNJLDBCQUEwQjtJQUMxQiwrQkFBK0I7QUFDbkM7O0FBRUE7SUFDSSxxQkFBcUI7SUFDckIsZUFBZTtJQUNmLCtCQUErQjtJQUMvQixnQ0FBZ0M7SUFDaEMsOEJBQThCO0FBQ2xDIiwiZmlsZSI6InNyYy9hcHAvZXZlbnRvL2V2ZW50b0VkaXQvZXZlbnRvRWRpdC5jb21wb25lbnQuY3NzIiwic291cmNlc0NvbnRlbnQiOlsiaSB7XHJcbiAgICBmb250LXNpemU6IDI1cHg7XHJcbn1cclxuXHJcbi5pY29uZXNTb2NpYWlzIGEge1xyXG4gICAgY29sb3I6IHJnYig5NCwgOTQsIDk0KTtcclxufVxyXG5cclxuLmNhcGl0YWxpemUge1xyXG4gICAgdGV4dC10cmFuc2Zvcm06IGNhcGl0YWxpemU7XHJcbiAgICBib3JkZXItYm90dG9tOiAxcHggc29saWQgc2lsdmVyO1xyXG59XHJcblxyXG4udGFiLXBhbmUge1xyXG4gICAgcGFkZGluZzogMjBweCA4cHggOHB4O1xyXG4gICAgYm9yZGVyLXRvcDogMHB4O1xyXG4gICAgYm9yZGVyLXJpZ2h0OiAxcHggc29saWQgI2RlZTJlNjtcclxuICAgIGJvcmRlci1ib3R0b206IDFweCBzb2xpZCAjZGVlMmU2O1xyXG4gICAgYm9yZGVyLWxlZnQ6IDFweCBzb2xpZCAjZGVlMmU2O1xyXG59Il19 */"

/***/ }),

/***/ "./src/app/evento/eventoEdit/eventoEdit.component.ts":
/*!***********************************************************!*\
  !*** ./src/app/evento/eventoEdit/eventoEdit.component.ts ***!
  \***********************************************************/
/*! exports provided: EventoEditComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EventoEditComponent", function() { return EventoEditComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var ngx_bootstrap_datepicker__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ngx-bootstrap/datepicker */ "./node_modules/ngx-bootstrap/datepicker/fesm2015/ngx-bootstrap-datepicker.js");
/* harmony import */ var ngx_toastr__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ngx-toastr */ "./node_modules/ngx-toastr/fesm2015/ngx-toastr.js");
/* harmony import */ var src_app_models_Evento__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! src/app/models/Evento */ "./src/app/models/Evento.ts");
/* harmony import */ var src_app_services_evento_service__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! src/app/services/evento.service */ "./src/app/services/evento.service.ts");








let EventoEditComponent = class EventoEditComponent {
    constructor(toastr, eventoService, fb, router, route, localeService) {
        this.toastr = toastr;
        this.eventoService = eventoService;
        this.fb = fb;
        this.router = router;
        this.route = route;
        this.localeService = localeService;
        this.titulo = 'Editar Evento';
        this.evento = new src_app_models_Evento__WEBPACK_IMPORTED_MODULE_6__["Evento"]();
        this.imgArrowWidth = 50;
        this.imgArrowMarge = 2;
        this.imagemUrl = 'assets/img/upload.png';
        this.dataAtual = '';
        this.localeService.use('pt-br');
    }
    // retorna todos os Lotes
    get lotes() {
        return this.registerForm.get('lotes');
    }
    // retorna todas as Redes sociais
    get redesSociais() {
        return this.registerForm.get('redesSociais');
    }
    ngOnInit() {
        this.validation();
        this.carregarEvento();
    }
    carregarEvento() {
        const idEvento = +this.router.snapshot.paramMap.get('id'); // + converte uma string para number
        // tslint:disable-next-line:align
        this.eventoService.getEventoById(idEvento)
            // tslint:disable-next-line: deprecation
            .subscribe((evento) => {
            this.evento = Object.assign({}, evento);
            this.fileNameToUpdate = evento.imagemUrl.toString();
            this.imagemUrl = `http://localhost:5000/Resources/images/${this.evento.imagemUrl}?_ts=${this.dataAtual}`;
            this.evento.imagemUrl = '';
            this.registerForm.patchValue(this.evento);
            this.evento.lotes.forEach(lote => {
                this.lotes.push(this.criaLote(lote));
            });
            this.evento.redesSociais.forEach(redeSocial => {
                this.redesSociais.push(this.criaRedeSocial(redeSocial));
            });
        });
    }
    validation() {
        this.registerForm = this.fb.group({
            id: [],
            // validaçoes dos campos
            tema: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].minLength(4), _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].maxLength(50)]],
            local: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].maxLength(30)]],
            dataEvento: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required],
            qtdPessoas: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].max(300)]],
            imagemUrl: [''],
            telefone: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required],
            email: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].email]],
            // this.fb.array vai permitir que seje adicionado uma lista de lotes
            lotes: this.fb.array([]),
            // this.fb.array vai permitir que seja adicionado uma lista de redes sociais
            redesSociais: this.fb.array([])
        });
        // console.log(this.registerForm);
    }
    criaLote(lote) {
        return this.fb.group({
            id: [lote.id],
            nome: [lote.nome, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required],
            quantidade: [lote.quantidade, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required],
            preco: [lote.preco, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required],
            dataInicio: [lote.dataInicio],
            dataFim: [lote.dataFim]
        });
    }
    criaRedeSocial(redeSocial) {
        return this.fb.group({
            id: [redeSocial.id],
            nome: [redeSocial.nome, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required],
            url: [redeSocial.url, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required]
        });
    }
    adicionarLote() {
        this.lotes.push(this.criaLote({ id: 0 }));
    }
    adicionarRedeSocial() {
        this.redesSociais.push(this.criaRedeSocial({ id: 0 }));
    }
    removerLote(id) {
        this.lotes.removeAt(id);
    }
    removerRedeSocial(id) {
        this.redesSociais.removeAt(id);
    }
    onFileChange(evento, file) {
        const reader = new FileReader();
        // carrega e troca a imagem apos seleciona-la
        reader.onload = (event) => this.imagemUrl = event.target.result;
        this.file = evento.target.files;
        reader.readAsDataURL(file[0]);
    }
    salvarEvento() {
        this.evento = Object.assign({ id: this.evento.id }, this.registerForm.value); // vai copiar todos os valores do formulário
        this.evento.imagemUrl = this.fileNameToUpdate;
        this.uploadImagem();
        // tslint:disable-next-line: deprecation
        this.eventoService.putEvento(this.evento).subscribe(() => {
            this.toastr.success('Editado com sucesso!');
        }, (error) => {
            this.toastr.error(`Erro ao editar: ${error}`);
            // console.log(error);
        });
    }
    uploadImagem() {
        if (this.registerForm.get('imagemUrl').value !== '') {
            this.eventoService.postUpload(this.file, this.fileNameToUpdate)
                // tslint:disable-next-line: deprecation
                .subscribe(() => {
                this.dataAtual = new Date().getMilliseconds().toString();
                location.reload();
                this.imagemUrl = `http://localhost:5000/Resources/images/${this.evento.imagemUrl}?_ts=${location.reload()}`;
            });
        }
    }
    // botao voltar para todos os eventos em geral
    backToGeneralEvents() {
        this.route.navigate(['/evento']);
    }
};
EventoEditComponent.ctorParameters = () => [
    { type: ngx_toastr__WEBPACK_IMPORTED_MODULE_5__["ToastrService"] },
    { type: src_app_services_evento_service__WEBPACK_IMPORTED_MODULE_7__["EventoService"] },
    { type: _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormBuilder"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_3__["ActivatedRoute"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_3__["Router"] },
    { type: ngx_bootstrap_datepicker__WEBPACK_IMPORTED_MODULE_4__["BsLocaleService"] }
];
EventoEditComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-eventoEdit',
        template: __webpack_require__(/*! raw-loader!./eventoEdit.component.html */ "./node_modules/raw-loader/index.js!./src/app/evento/eventoEdit/eventoEdit.component.html"),
        styles: [__webpack_require__(/*! ./eventoEdit.component.css */ "./src/app/evento/eventoEdit/eventoEdit.component.css")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [ngx_toastr__WEBPACK_IMPORTED_MODULE_5__["ToastrService"],
        src_app_services_evento_service__WEBPACK_IMPORTED_MODULE_7__["EventoService"],
        _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormBuilder"],
        _angular_router__WEBPACK_IMPORTED_MODULE_3__["ActivatedRoute"],
        _angular_router__WEBPACK_IMPORTED_MODULE_3__["Router"],
        ngx_bootstrap_datepicker__WEBPACK_IMPORTED_MODULE_4__["BsLocaleService"]])
], EventoEditComponent);



/***/ }),

/***/ "./src/app/models/Evento.ts":
/*!**********************************!*\
  !*** ./src/app/models/Evento.ts ***!
  \**********************************/
/*! exports provided: Evento */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Evento", function() { return Evento; });
class Evento {
    constructor() { }
}


/***/ }),

/***/ "./src/app/nav/nav.component.css":
/*!***************************************!*\
  !*** ./src/app/nav/nav.component.css ***!
  \***************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL25hdi9uYXYuY29tcG9uZW50LmNzcyJ9 */"

/***/ }),

/***/ "./src/app/nav/nav.component.ts":
/*!**************************************!*\
  !*** ./src/app/nav/nav.component.ts ***!
  \**************************************/
/*! exports provided: NavComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "NavComponent", function() { return NavComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var ngx_toastr__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ngx-toastr */ "./node_modules/ngx-toastr/fesm2015/ngx-toastr.js");
/* harmony import */ var _services_auth_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../services/auth.service */ "./src/app/services/auth.service.ts");





let NavComponent = class NavComponent {
    constructor(authService, router, toastr) {
        this.authService = authService;
        this.router = router;
        this.toastr = toastr;
    }
    ngOnInit() {
    }
    loggedIn() {
        return this.authService.loggedIn();
    }
    entrar() {
        this.router.navigate(['/user/login']);
    }
    // deslogar da sessao
    logout() {
        localStorage.removeItem('token'); // remove o token gerado quando estiver logado
        this.toastr.show('Log Out');
        this.router.navigate(['/user/login']);
    }
    showMenu() {
        return this.router.url !== '/user/login';
    }
    userName() {
        return sessionStorage.getItem('username');
    }
};
NavComponent.ctorParameters = () => [
    { type: _services_auth_service__WEBPACK_IMPORTED_MODULE_4__["AuthService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] },
    { type: ngx_toastr__WEBPACK_IMPORTED_MODULE_3__["ToastrService"] }
];
NavComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-nav',
        template: __webpack_require__(/*! raw-loader!./nav.component.html */ "./node_modules/raw-loader/index.js!./src/app/nav/nav.component.html"),
        styles: [__webpack_require__(/*! ./nav.component.css */ "./src/app/nav/nav.component.css")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_services_auth_service__WEBPACK_IMPORTED_MODULE_4__["AuthService"],
        _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"],
        ngx_toastr__WEBPACK_IMPORTED_MODULE_3__["ToastrService"]])
], NavComponent);



/***/ }),

/***/ "./src/app/palestrantes/palestrantes.component.css":
/*!*********************************************************!*\
  !*** ./src/app/palestrantes/palestrantes.component.css ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3BhbGVzdHJhbnRlcy9wYWxlc3RyYW50ZXMuY29tcG9uZW50LmNzcyJ9 */"

/***/ }),

/***/ "./src/app/palestrantes/palestrantes.component.ts":
/*!********************************************************!*\
  !*** ./src/app/palestrantes/palestrantes.component.ts ***!
  \********************************************************/
/*! exports provided: PalestrantesComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PalestrantesComponent", function() { return PalestrantesComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let PalestrantesComponent = class PalestrantesComponent {
    constructor() {
        this.tituloPalestrantes = 'Palestrantes';
    }
    ngOnInit() {
    }
};
PalestrantesComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-palestrantes',
        template: __webpack_require__(/*! raw-loader!./palestrantes.component.html */ "./node_modules/raw-loader/index.js!./src/app/palestrantes/palestrantes.component.html"),
        styles: [__webpack_require__(/*! ./palestrantes.component.css */ "./src/app/palestrantes/palestrantes.component.css")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
], PalestrantesComponent);



/***/ }),

/***/ "./src/app/services/auth.service.ts":
/*!******************************************!*\
  !*** ./src/app/services/auth.service.ts ***!
  \******************************************/
/*! exports provided: AuthService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthService", function() { return AuthService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _auth0_angular_jwt__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @auth0/angular-jwt */ "./node_modules/@auth0/angular-jwt/fesm2015/auth0-angular-jwt.js");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm2015/operators/index.js");





let AuthService = class AuthService {
    constructor(http) {
        this.http = http;
        this.baseURL = 'http://localhost:5000/api/user/';
        this.jwtHelper = new _auth0_angular_jwt__WEBPACK_IMPORTED_MODULE_3__["JwtHelperService"]();
    }
    login(model) {
        return this.http
            .post(`${this.baseURL}login`, model).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["map"])((response) => {
            const user = response;
            if (user) {
                localStorage.setItem('token', user.token); // salva o token no localStorage
                this.decodedToken = this.jwtHelper.decodeToken(user.token);
                sessionStorage.setItem('username', this.decodedToken.unique_name);
            }
        }));
    }
    register(model) {
        return this.http.post(`${this.baseURL}register`, model);
    }
    loggedIn() {
        const token = localStorage.getItem('token');
        return this.jwtHelper.isTokenExpired(token);
    }
};
AuthService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_1__["HttpClient"] }
];
AuthService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["Injectable"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_1__["HttpClient"]])
], AuthService);



/***/ }),

/***/ "./src/app/services/evento.service.ts":
/*!********************************************!*\
  !*** ./src/app/services/evento.service.ts ***!
  \********************************************/
/*! exports provided: EventoService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EventoService", function() { return EventoService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");



let EventoService = class EventoService {
    // tokenHeader: HttpHeaders;
    constructor(http) {
        this.http = http;
        this.baseURL = 'http://localhost:5000/api/evento';
        // this.tokenHeader = new HttpHeaders({'Authorization': `Bearer ${localStorage.getItem('token')}`});
    }
    getAllEvento() {
        const tokenHeader = new _angular_common_http__WEBPACK_IMPORTED_MODULE_1__["HttpHeaders"]({ 'Authorization': `Bearer ${localStorage.getItem('token')}` });
        return this.http.get(this.baseURL); // { headers: this.tokenHeader }
    }
    getEventoByTema(tema) {
        return this.http.get(`${this.baseURL}/getByTema/${tema}`);
    }
    getEventoById(id) {
        return this.http.get(`${this.baseURL}/${id}`);
    }
    postUpload(file, name) {
        // tslint:disable-next-line: no-angle-bracket-type-assertion
        const fileToUpload = file[0];
        const formData = new FormData();
        formData.append('file', fileToUpload, name);
        return this.http.post(`${this.baseURL}/upload`, formData); // { headers: this.tokenHeader }
    }
    // recebimento via POST dos formuláios
    postEvento(evento) {
        return this.http.post(`${this.baseURL}`, evento); // { headers: this.tokenHeader}
    }
    putEvento(evento) {
        return this.http.put(`${this.baseURL}/${evento.id}`, evento); // { headers: this.tokenHeader}
    }
    deleteEvento(id) {
        return this.http.delete(`${this.baseURL}/${id}`); // { headers: this.tokenHeader }
    }
};
EventoService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_1__["HttpClient"] }
];
EventoService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["Injectable"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_1__["HttpClient"]])
], EventoService);



/***/ }),

/***/ "./src/app/shared/titulo/titulo.component.css":
/*!****************************************************!*\
  !*** ./src/app/shared/titulo/titulo.component.css ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3NoYXJlZC90aXR1bG8vdGl0dWxvLmNvbXBvbmVudC5jc3MifQ== */"

/***/ }),

/***/ "./src/app/shared/titulo/titulo.component.ts":
/*!***************************************************!*\
  !*** ./src/app/shared/titulo/titulo.component.ts ***!
  \***************************************************/
/*! exports provided: TituloComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TituloComponent", function() { return TituloComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let TituloComponent = class TituloComponent {
    constructor() { }
    ngOnInit() {
    }
};
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
], TituloComponent.prototype, "title", void 0);
TituloComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-titulo',
        template: __webpack_require__(/*! raw-loader!./titulo.component.html */ "./node_modules/raw-loader/index.js!./src/app/shared/titulo/titulo.component.html"),
        styles: [__webpack_require__(/*! ./titulo.component.css */ "./src/app/shared/titulo/titulo.component.css")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
], TituloComponent);



/***/ }),

/***/ "./src/app/user/login/login.component.css":
/*!************************************************!*\
  !*** ./src/app/user/login/login.component.css ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".form-signin {\r\n    width: 100%;\r\n    max-width: 330px;\r\n    padding: 15px;\r\n    margin: 0 auto;\r\n  }\r\n  .form-signin .checkbox {\r\n    font-weight: 400;\r\n  }\r\n  .form-signin .form-control {\r\n    position: relative;\r\n    box-sizing: border-box;\r\n    height: auto;\r\n    padding: 10px;\r\n    font-size: 16px;\r\n  }\r\n  .form-signin .form-control:focus {\r\n    z-index: 2;\r\n  }\r\n  .form-signin input[type=\"email\"] {\r\n    margin-bottom: -1px;\r\n    border-bottom-right-radius: 0;\r\n    border-bottom-left-radius: 0;\r\n  }\r\n  .form-signin input[type=\"password\"] {\r\n    margin-bottom: 10px;\r\n    border-top-left-radius: 0;\r\n    border-top-right-radius: 0;\r\n  }\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvdXNlci9sb2dpbi9sb2dpbi5jb21wb25lbnQuY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0lBQ0ksV0FBVztJQUNYLGdCQUFnQjtJQUNoQixhQUFhO0lBQ2IsY0FBYztFQUNoQjtFQUNBO0lBQ0UsZ0JBQWdCO0VBQ2xCO0VBQ0E7SUFDRSxrQkFBa0I7SUFDbEIsc0JBQXNCO0lBQ3RCLFlBQVk7SUFDWixhQUFhO0lBQ2IsZUFBZTtFQUNqQjtFQUNBO0lBQ0UsVUFBVTtFQUNaO0VBQ0E7SUFDRSxtQkFBbUI7SUFDbkIsNkJBQTZCO0lBQzdCLDRCQUE0QjtFQUM5QjtFQUNBO0lBQ0UsbUJBQW1CO0lBQ25CLHlCQUF5QjtJQUN6QiwwQkFBMEI7RUFDNUIiLCJmaWxlIjoic3JjL2FwcC91c2VyL2xvZ2luL2xvZ2luLmNvbXBvbmVudC5jc3MiLCJzb3VyY2VzQ29udGVudCI6WyIuZm9ybS1zaWduaW4ge1xyXG4gICAgd2lkdGg6IDEwMCU7XHJcbiAgICBtYXgtd2lkdGg6IDMzMHB4O1xyXG4gICAgcGFkZGluZzogMTVweDtcclxuICAgIG1hcmdpbjogMCBhdXRvO1xyXG4gIH1cclxuICAuZm9ybS1zaWduaW4gLmNoZWNrYm94IHtcclxuICAgIGZvbnQtd2VpZ2h0OiA0MDA7XHJcbiAgfVxyXG4gIC5mb3JtLXNpZ25pbiAuZm9ybS1jb250cm9sIHtcclxuICAgIHBvc2l0aW9uOiByZWxhdGl2ZTtcclxuICAgIGJveC1zaXppbmc6IGJvcmRlci1ib3g7XHJcbiAgICBoZWlnaHQ6IGF1dG87XHJcbiAgICBwYWRkaW5nOiAxMHB4O1xyXG4gICAgZm9udC1zaXplOiAxNnB4O1xyXG4gIH1cclxuICAuZm9ybS1zaWduaW4gLmZvcm0tY29udHJvbDpmb2N1cyB7XHJcbiAgICB6LWluZGV4OiAyO1xyXG4gIH1cclxuICAuZm9ybS1zaWduaW4gaW5wdXRbdHlwZT1cImVtYWlsXCJdIHtcclxuICAgIG1hcmdpbi1ib3R0b206IC0xcHg7XHJcbiAgICBib3JkZXItYm90dG9tLXJpZ2h0LXJhZGl1czogMDtcclxuICAgIGJvcmRlci1ib3R0b20tbGVmdC1yYWRpdXM6IDA7XHJcbiAgfVxyXG4gIC5mb3JtLXNpZ25pbiBpbnB1dFt0eXBlPVwicGFzc3dvcmRcIl0ge1xyXG4gICAgbWFyZ2luLWJvdHRvbTogMTBweDtcclxuICAgIGJvcmRlci10b3AtbGVmdC1yYWRpdXM6IDA7XHJcbiAgICBib3JkZXItdG9wLXJpZ2h0LXJhZGl1czogMDtcclxuICB9Il19 */"

/***/ }),

/***/ "./src/app/user/login/login.component.ts":
/*!***********************************************!*\
  !*** ./src/app/user/login/login.component.ts ***!
  \***********************************************/
/*! exports provided: LoginComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LoginComponent", function() { return LoginComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var ngx_toastr__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ngx-toastr */ "./node_modules/ngx-toastr/fesm2015/ngx-toastr.js");
/* harmony import */ var src_app_services_auth_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/services/auth.service */ "./src/app/services/auth.service.ts");





let LoginComponent = class LoginComponent {
    constructor(authServices, router, toastr) {
        this.authServices = authServices;
        this.router = router;
        this.toastr = toastr;
        this.titulo = 'Login';
        this.model = {};
    }
    ngOnInit() {
        // verificando se o localStorage existe o token
        if (localStorage.getItem('token') !== null) {
            this.router.navigate(['/dashboard']); // redireciona para a pagina de dashboard
        }
    }
    login() {
        this.authServices.login(this.model)
            .subscribe(() => {
            this.router.navigate(['/dashboard']); // redireciona para a pagina de dashboard
            this.toastr.success('Logado com Sucesso!');
        }, error => {
            this.toastr.error(`Falha ao tentar Logar, usuário ou senha incorreto ${error}`);
        });
    }
};
LoginComponent.ctorParameters = () => [
    { type: src_app_services_auth_service__WEBPACK_IMPORTED_MODULE_4__["AuthService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] },
    { type: ngx_toastr__WEBPACK_IMPORTED_MODULE_3__["ToastrService"] }
];
LoginComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-login',
        template: __webpack_require__(/*! raw-loader!./login.component.html */ "./node_modules/raw-loader/index.js!./src/app/user/login/login.component.html"),
        styles: [__webpack_require__(/*! ./login.component.css */ "./src/app/user/login/login.component.css")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [src_app_services_auth_service__WEBPACK_IMPORTED_MODULE_4__["AuthService"],
        _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"],
        ngx_toastr__WEBPACK_IMPORTED_MODULE_3__["ToastrService"]])
], LoginComponent);



/***/ }),

/***/ "./src/app/user/registration/registration.component.css":
/*!**************************************************************!*\
  !*** ./src/app/user/registration/registration.component.css ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3VzZXIvcmVnaXN0cmF0aW9uL3JlZ2lzdHJhdGlvbi5jb21wb25lbnQuY3NzIn0= */"

/***/ }),

/***/ "./src/app/user/registration/registration.component.ts":
/*!*************************************************************!*\
  !*** ./src/app/user/registration/registration.component.ts ***!
  \*************************************************************/
/*! exports provided: RegistrationComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RegistrationComponent", function() { return RegistrationComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var ngx_toastr__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ngx-toastr */ "./node_modules/ngx-toastr/fesm2015/ngx-toastr.js");
/* harmony import */ var src_app_services_auth_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! src/app/services/auth.service */ "./src/app/services/auth.service.ts");






let RegistrationComponent = class RegistrationComponent {
    constructor(authServices, router, fb, toastr) {
        this.authServices = authServices;
        this.router = router;
        this.fb = fb;
        this.toastr = toastr;
    }
    ngOnInit() {
        this.Validation();
    }
    Validation() {
        this.registerForm = this.fb.group({
            fullName: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required],
            email: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].email]],
            userName: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required],
            passwords: this.fb.group({
                password: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].minLength(4)]],
                confirmPassword: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required]
            }, { validator: this.compararSenhas })
        });
    }
    compararSenhas(fb) {
        const confirmSenhaCtrl = fb.get('confirmPassword');
        if (confirmSenhaCtrl.errors == null || 'mismatch' in confirmSenhaCtrl.errors) {
            if (fb.get('password').value !== confirmSenhaCtrl.value) {
                confirmSenhaCtrl.setErrors({ mismatch: true });
            }
            else {
                confirmSenhaCtrl.setErrors(null);
            }
        }
    }
    cadastrarUsuario() {
        if (this.registerForm.valid) {
            this.user = Object.assign({ password: this.registerForm.get('passwords.password').value }, this.registerForm.value);
            // console.log(this.user);
            this.authServices.register(this.user).subscribe(() => {
                this.router.navigate(['/user/login']);
                this.toastr.success('Cadastrado Realizado com Sucesso!');
            }, error => {
                const erro = error.error;
                erro.forEach(element => {
                    switch (element.code) {
                        case 'DuplicateUserName':
                            this.toastr.error('Cadastro Duplicado!');
                            break;
                        default:
                            this.toastr.error(`Erro no Cadastro! CODE: ${element.code}`);
                            break;
                    }
                });
            });
        }
    }
};
RegistrationComponent.ctorParameters = () => [
    { type: src_app_services_auth_service__WEBPACK_IMPORTED_MODULE_5__["AuthService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_3__["Router"] },
    { type: _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormBuilder"] },
    { type: ngx_toastr__WEBPACK_IMPORTED_MODULE_4__["ToastrService"] }
];
RegistrationComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-registration',
        template: __webpack_require__(/*! raw-loader!./registration.component.html */ "./node_modules/raw-loader/index.js!./src/app/user/registration/registration.component.html"),
        styles: [__webpack_require__(/*! ./registration.component.css */ "./src/app/user/registration/registration.component.css")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [src_app_services_auth_service__WEBPACK_IMPORTED_MODULE_5__["AuthService"],
        _angular_router__WEBPACK_IMPORTED_MODULE_3__["Router"],
        _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormBuilder"],
        ngx_toastr__WEBPACK_IMPORTED_MODULE_4__["ToastrService"]])
], RegistrationComponent);



/***/ }),

/***/ "./src/app/user/user.component.css":
/*!*****************************************!*\
  !*** ./src/app/user/user.component.css ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3VzZXIvdXNlci5jb21wb25lbnQuY3NzIn0= */"

/***/ }),

/***/ "./src/app/user/user.component.ts":
/*!****************************************!*\
  !*** ./src/app/user/user.component.ts ***!
  \****************************************/
/*! exports provided: UserComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UserComponent", function() { return UserComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let UserComponent = class UserComponent {
    constructor() { }
    ngOnInit() {
    }
};
UserComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-user',
        template: __webpack_require__(/*! raw-loader!./user.component.html */ "./node_modules/raw-loader/index.js!./src/app/user/user.component.html"),
        styles: [__webpack_require__(/*! ./user.component.css */ "./src/app/user/user.component.css")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
], UserComponent);



/***/ }),

/***/ "./src/app/util/Constants.ts":
/*!***********************************!*\
  !*** ./src/app/util/Constants.ts ***!
  \***********************************/
/*! exports provided: Constants */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Constants", function() { return Constants; });
class Constants {
}
Constants.DATE_FMT = 'dd/MM/yyyy';
Constants.DATE_TIME_FMT = `${Constants.DATE_FMT} hh:mm`;


/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
const environment = {
    production: false
};
/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm2015/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(err => console.error(err));


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Users\Matheus\Desktop\ProAgil-dotnet-core\ProAgil-App\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main-es2015.js.map