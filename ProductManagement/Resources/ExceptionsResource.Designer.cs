﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ExceptionsResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionsResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebAPI.Resources.ExceptionsResource", typeof(ExceptionsResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Este album já está finalizado e não pode ser alterado..
        /// </summary>
        public static string AlbumAlreadyFinishedException {
            get {
                return ResourceManager.GetString("AlbumAlreadyFinishedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item não encontrado no carrinho..
        /// </summary>
        public static string CartItemNotFoundException {
            get {
                return ResourceManager.GetString("CartItemNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cliente não pode ter favoritos.
        /// </summary>
        public static string ClientCantHaveFavorites {
            get {
                return ResourceManager.GetString("ClientCantHaveFavorites", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nenhum registro encontrado com esse e-mail ou não tem acesso à essa galeria..
        /// </summary>
        public static string ClientNotFoundedException {
            get {
                return ResourceManager.GetString("ClientNotFoundedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cliente não encontrado..
        /// </summary>
        public static string ClientNotFoundException {
            get {
                return ResourceManager.GetString("ClientNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Download dos arquivos da cena inválido..
        /// </summary>
        public static string DownloadFilesBySceneInvalidException {
            get {
                return ResourceManager.GetString("DownloadFilesBySceneInvalidException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Erro ao tentar cadastrar usuário, por favor tente novamente mais tarde..
        /// </summary>
        public static string ErrorWhenTryRegisterUserException {
            get {
                return ResourceManager.GetString("ErrorWhenTryRegisterUserException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tamanho máximo de caracteres da Descrição excedido..
        /// </summary>
        public static string ExceedLimitDescriptionException {
            get {
                return ResourceManager.GetString("ExceedLimitDescriptionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tamanho máximo de caracteres do Título excedido..
        /// </summary>
        public static string ExceedLimitTitleException {
            get {
                return ResourceManager.GetString("ExceedLimitTitleException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A sessão expirou..
        /// </summary>
        public static string ExpiredSessionException {
            get {
                return ResourceManager.GetString("ExpiredSessionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Falha ao redefinir a nova senha..
        /// </summary>
        public static string FailToResetPasswordException {
            get {
                return ResourceManager.GetString("FailToResetPasswordException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A arquivo já foi adicionado aos favoritos.
        /// </summary>
        public static string FileAlreadyAddedFavoritesException {
            get {
                return ResourceManager.GetString("FileAlreadyAddedFavoritesException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O Arquivo já foi selecionado..
        /// </summary>
        public static string FileAlreadySelectedException {
            get {
                return ResourceManager.GetString("FileAlreadySelectedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arquivo não encontrado..
        /// </summary>
        public static string FileNotFoundedException {
            get {
                return ResourceManager.GetString("FileNotFoundedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Album não encontrado..
        /// </summary>
        public static string GalleryAlbumNotExistsException {
            get {
                return ResourceManager.GetString("GalleryAlbumNotExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Galeria não encontrada..
        /// </summary>
        public static string GalleryNotExistsException {
            get {
                return ResourceManager.GetString("GalleryNotExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email inválido..
        /// </summary>
        public static string InvalidEmailChangePasswordException {
            get {
                return ResourceManager.GetString("InvalidEmailChangePasswordException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to E-mail ou senha incorretos..
        /// </summary>
        public static string InvalidEmailException {
            get {
                return ResourceManager.GetString("InvalidEmailException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login do Facebook inválido..
        /// </summary>
        public static string InvalidFacebookLogin {
            get {
                return ResourceManager.GetString("InvalidFacebookLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O texto do comentário está inválido..
        /// </summary>
        public static string InvalidGalleryAlbumCommentException {
            get {
                return ResourceManager.GetString("InvalidGalleryAlbumCommentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login do Google inválido..
        /// </summary>
        public static string InvalidGoogleLogin {
            get {
                return ResourceManager.GetString("InvalidGoogleLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nova senha inválida..
        /// </summary>
        public static string InvalidNewPasswordException {
            get {
                return ResourceManager.GetString("InvalidNewPasswordException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não foi possível salvar o pedido, houve um erro desconhecido. .
        /// </summary>
        public static string InvalidOrderException {
            get {
                return ResourceManager.GetString("InvalidOrderException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não foi possível encontrar a ordem..
        /// </summary>
        public static string InvalidOrderIdException {
            get {
                return ResourceManager.GetString("InvalidOrderIdException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Número de parcelas inválido..
        /// </summary>
        public static string InvalidParcelsNumberException {
            get {
                return ResourceManager.GetString("InvalidParcelsNumberException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lista de produtos inválida.
        /// </summary>
        public static string InvalidProductListException {
            get {
                return ResourceManager.GetString("InvalidProductListException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opção {0} do produto {1} inválida..
        /// </summary>
        public static string InvalidProductOptionException {
            get {
                return ResourceManager.GetString("InvalidProductOptionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Quantidade do item inválida..
        /// </summary>
        public static string InvalidQuantityShoppingCartItemException {
            get {
                return ResourceManager.GetString("InvalidQuantityShoppingCartItemException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Código (Token) de recuperação inválido..
        /// </summary>
        public static string InvalidRecoveryTokenException {
            get {
                return ResourceManager.GetString("InvalidRecoveryTokenException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Link de compartilhamento inválido..
        /// </summary>
        public static string InvalidShareLinkHashException {
            get {
                return ResourceManager.GetString("InvalidShareLinkHashException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forma de entrega inválida.
        /// </summary>
        public static string InvalidShippmentMethodException {
            get {
                return ResourceManager.GetString("InvalidShippmentMethodException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dados do usuário inválido.
        /// </summary>
        public static string InvalidUserDataException {
            get {
                return ResourceManager.GetString("InvalidUserDataException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CEP não encontrado..
        /// </summary>
        public static string InvalidZipCodeException {
            get {
                return ResourceManager.GetString("InvalidZipCodeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login inválido..
        /// </summary>
        public static string LoginInvalidException {
            get {
                return ResourceManager.GetString("LoginInvalidException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tipo de autenticação inválido..
        /// </summary>
        public static string LoginInvalidGrantTypeException {
            get {
                return ResourceManager.GetString("LoginInvalidGrantTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Você já atingiu o número máximo de arquivos dessa seleção..
        /// </summary>
        public static string MaxFilesSelectionException {
            get {
                return ResourceManager.GetString("MaxFilesSelectionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nenhuma seleção encontrada para este usuário..
        /// </summary>
        public static string NoSelectionsFoundException {
            get {
                return ResourceManager.GetString("NoSelectionsFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não foi possível carregar as formas de pagamento: {0}.
        /// </summary>
        public static string NotPossibleLoadPaymentMethodsException {
            get {
                return ResourceManager.GetString("NotPossibleLoadPaymentMethodsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A url deste parceiro não é valida..
        /// </summary>
        public static string PartnerNotValidException {
            get {
                return ResourceManager.GetString("PartnerNotValidException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Produto {0} não encontrado..
        /// </summary>
        public static string ProductNotFoundException {
            get {
                return ResourceManager.GetString("ProductNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tipo da resolução não encontrado..
        /// </summary>
        public static string ResolutionDownloadTypeNotFoundException {
            get {
                return ResourceManager.GetString("ResolutionDownloadTypeNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nenhuma pasta encontrada com os parâmetros fornecidos..
        /// </summary>
        public static string SceneNotFound {
            get {
                return ResourceManager.GetString("SceneNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cena sem arquivos.
        /// </summary>
        public static string SceneWithoutFilesException {
            get {
                return ResourceManager.GetString("SceneWithoutFilesException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Está seleção já está finalizada e não pode ser alterada..
        /// </summary>
        public static string SelectionAlreadyFinishedException {
            get {
                return ResourceManager.GetString("SelectionAlreadyFinishedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A seleção não tem o mínimo de arquivos selecionados, por isso não pode ser finalizada..
        /// </summary>
        public static string SelectionMinFilesRequiredException {
            get {
                return ResourceManager.GetString("SelectionMinFilesRequiredException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A seleção precisa ter arquivos..
        /// </summary>
        public static string SelectionMustHaveFilesException {
            get {
                return ResourceManager.GetString("SelectionMustHaveFilesException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Seleção não econtrada..
        /// </summary>
        public static string SelectionNotFoundException {
            get {
                return ResourceManager.GetString("SelectionNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não foi possível encontrar informações de preço desse produto configurado no parceiro..
        /// </summary>
        public static string UnableToFindOptionsException {
            get {
                return ResourceManager.GetString("UnableToFindOptionsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Já existe um usuário cadastrado com este e-mail..
        /// </summary>
        public static string UserAlreadyExistsException {
            get {
                return ResourceManager.GetString("UserAlreadyExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usuário não encontrado..
        /// </summary>
        public static string UserNotFoundedException {
            get {
                return ResourceManager.GetString("UserNotFoundedException", resourceCulture);
            }
        }
    }
}