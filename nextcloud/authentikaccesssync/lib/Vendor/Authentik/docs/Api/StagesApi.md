# OCA\AuthentikAccessSync\Vendor\Authentik\StagesApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**stagesAllDestroy()**](StagesApi.md#stagesAllDestroy) | **DELETE** /stages/all/{stage_uuid}/ |  |
| [**stagesAllList()**](StagesApi.md#stagesAllList) | **GET** /stages/all/ |  |
| [**stagesAllRetrieve()**](StagesApi.md#stagesAllRetrieve) | **GET** /stages/all/{stage_uuid}/ |  |
| [**stagesAllTypesList()**](StagesApi.md#stagesAllTypesList) | **GET** /stages/all/types/ |  |
| [**stagesAllUsedByList()**](StagesApi.md#stagesAllUsedByList) | **GET** /stages/all/{stage_uuid}/used_by/ |  |
| [**stagesAllUserSettingsList()**](StagesApi.md#stagesAllUserSettingsList) | **GET** /stages/all/user_settings/ |  |
| [**stagesAuthenticatorDuoCreate()**](StagesApi.md#stagesAuthenticatorDuoCreate) | **POST** /stages/authenticator/duo/ |  |
| [**stagesAuthenticatorDuoDestroy()**](StagesApi.md#stagesAuthenticatorDuoDestroy) | **DELETE** /stages/authenticator/duo/{stage_uuid}/ |  |
| [**stagesAuthenticatorDuoEnrollmentStatusCreate()**](StagesApi.md#stagesAuthenticatorDuoEnrollmentStatusCreate) | **POST** /stages/authenticator/duo/{stage_uuid}/enrollment_status/ |  |
| [**stagesAuthenticatorDuoImportDeviceManualCreate()**](StagesApi.md#stagesAuthenticatorDuoImportDeviceManualCreate) | **POST** /stages/authenticator/duo/{stage_uuid}/import_device_manual/ |  |
| [**stagesAuthenticatorDuoImportDevicesAutomaticCreate()**](StagesApi.md#stagesAuthenticatorDuoImportDevicesAutomaticCreate) | **POST** /stages/authenticator/duo/{stage_uuid}/import_devices_automatic/ |  |
| [**stagesAuthenticatorDuoList()**](StagesApi.md#stagesAuthenticatorDuoList) | **GET** /stages/authenticator/duo/ |  |
| [**stagesAuthenticatorDuoPartialUpdate()**](StagesApi.md#stagesAuthenticatorDuoPartialUpdate) | **PATCH** /stages/authenticator/duo/{stage_uuid}/ |  |
| [**stagesAuthenticatorDuoRetrieve()**](StagesApi.md#stagesAuthenticatorDuoRetrieve) | **GET** /stages/authenticator/duo/{stage_uuid}/ |  |
| [**stagesAuthenticatorDuoUpdate()**](StagesApi.md#stagesAuthenticatorDuoUpdate) | **PUT** /stages/authenticator/duo/{stage_uuid}/ |  |
| [**stagesAuthenticatorDuoUsedByList()**](StagesApi.md#stagesAuthenticatorDuoUsedByList) | **GET** /stages/authenticator/duo/{stage_uuid}/used_by/ |  |
| [**stagesAuthenticatorEmailCreate()**](StagesApi.md#stagesAuthenticatorEmailCreate) | **POST** /stages/authenticator/email/ |  |
| [**stagesAuthenticatorEmailDestroy()**](StagesApi.md#stagesAuthenticatorEmailDestroy) | **DELETE** /stages/authenticator/email/{stage_uuid}/ |  |
| [**stagesAuthenticatorEmailList()**](StagesApi.md#stagesAuthenticatorEmailList) | **GET** /stages/authenticator/email/ |  |
| [**stagesAuthenticatorEmailPartialUpdate()**](StagesApi.md#stagesAuthenticatorEmailPartialUpdate) | **PATCH** /stages/authenticator/email/{stage_uuid}/ |  |
| [**stagesAuthenticatorEmailRetrieve()**](StagesApi.md#stagesAuthenticatorEmailRetrieve) | **GET** /stages/authenticator/email/{stage_uuid}/ |  |
| [**stagesAuthenticatorEmailUpdate()**](StagesApi.md#stagesAuthenticatorEmailUpdate) | **PUT** /stages/authenticator/email/{stage_uuid}/ |  |
| [**stagesAuthenticatorEmailUsedByList()**](StagesApi.md#stagesAuthenticatorEmailUsedByList) | **GET** /stages/authenticator/email/{stage_uuid}/used_by/ |  |
| [**stagesAuthenticatorEndpointGdtcCreate()**](StagesApi.md#stagesAuthenticatorEndpointGdtcCreate) | **POST** /stages/authenticator/endpoint_gdtc/ |  |
| [**stagesAuthenticatorEndpointGdtcDestroy()**](StagesApi.md#stagesAuthenticatorEndpointGdtcDestroy) | **DELETE** /stages/authenticator/endpoint_gdtc/{stage_uuid}/ |  |
| [**stagesAuthenticatorEndpointGdtcList()**](StagesApi.md#stagesAuthenticatorEndpointGdtcList) | **GET** /stages/authenticator/endpoint_gdtc/ |  |
| [**stagesAuthenticatorEndpointGdtcPartialUpdate()**](StagesApi.md#stagesAuthenticatorEndpointGdtcPartialUpdate) | **PATCH** /stages/authenticator/endpoint_gdtc/{stage_uuid}/ |  |
| [**stagesAuthenticatorEndpointGdtcRetrieve()**](StagesApi.md#stagesAuthenticatorEndpointGdtcRetrieve) | **GET** /stages/authenticator/endpoint_gdtc/{stage_uuid}/ |  |
| [**stagesAuthenticatorEndpointGdtcUpdate()**](StagesApi.md#stagesAuthenticatorEndpointGdtcUpdate) | **PUT** /stages/authenticator/endpoint_gdtc/{stage_uuid}/ |  |
| [**stagesAuthenticatorEndpointGdtcUsedByList()**](StagesApi.md#stagesAuthenticatorEndpointGdtcUsedByList) | **GET** /stages/authenticator/endpoint_gdtc/{stage_uuid}/used_by/ |  |
| [**stagesAuthenticatorSmsCreate()**](StagesApi.md#stagesAuthenticatorSmsCreate) | **POST** /stages/authenticator/sms/ |  |
| [**stagesAuthenticatorSmsDestroy()**](StagesApi.md#stagesAuthenticatorSmsDestroy) | **DELETE** /stages/authenticator/sms/{stage_uuid}/ |  |
| [**stagesAuthenticatorSmsList()**](StagesApi.md#stagesAuthenticatorSmsList) | **GET** /stages/authenticator/sms/ |  |
| [**stagesAuthenticatorSmsPartialUpdate()**](StagesApi.md#stagesAuthenticatorSmsPartialUpdate) | **PATCH** /stages/authenticator/sms/{stage_uuid}/ |  |
| [**stagesAuthenticatorSmsRetrieve()**](StagesApi.md#stagesAuthenticatorSmsRetrieve) | **GET** /stages/authenticator/sms/{stage_uuid}/ |  |
| [**stagesAuthenticatorSmsUpdate()**](StagesApi.md#stagesAuthenticatorSmsUpdate) | **PUT** /stages/authenticator/sms/{stage_uuid}/ |  |
| [**stagesAuthenticatorSmsUsedByList()**](StagesApi.md#stagesAuthenticatorSmsUsedByList) | **GET** /stages/authenticator/sms/{stage_uuid}/used_by/ |  |
| [**stagesAuthenticatorStaticCreate()**](StagesApi.md#stagesAuthenticatorStaticCreate) | **POST** /stages/authenticator/static/ |  |
| [**stagesAuthenticatorStaticDestroy()**](StagesApi.md#stagesAuthenticatorStaticDestroy) | **DELETE** /stages/authenticator/static/{stage_uuid}/ |  |
| [**stagesAuthenticatorStaticList()**](StagesApi.md#stagesAuthenticatorStaticList) | **GET** /stages/authenticator/static/ |  |
| [**stagesAuthenticatorStaticPartialUpdate()**](StagesApi.md#stagesAuthenticatorStaticPartialUpdate) | **PATCH** /stages/authenticator/static/{stage_uuid}/ |  |
| [**stagesAuthenticatorStaticRetrieve()**](StagesApi.md#stagesAuthenticatorStaticRetrieve) | **GET** /stages/authenticator/static/{stage_uuid}/ |  |
| [**stagesAuthenticatorStaticUpdate()**](StagesApi.md#stagesAuthenticatorStaticUpdate) | **PUT** /stages/authenticator/static/{stage_uuid}/ |  |
| [**stagesAuthenticatorStaticUsedByList()**](StagesApi.md#stagesAuthenticatorStaticUsedByList) | **GET** /stages/authenticator/static/{stage_uuid}/used_by/ |  |
| [**stagesAuthenticatorTotpCreate()**](StagesApi.md#stagesAuthenticatorTotpCreate) | **POST** /stages/authenticator/totp/ |  |
| [**stagesAuthenticatorTotpDestroy()**](StagesApi.md#stagesAuthenticatorTotpDestroy) | **DELETE** /stages/authenticator/totp/{stage_uuid}/ |  |
| [**stagesAuthenticatorTotpList()**](StagesApi.md#stagesAuthenticatorTotpList) | **GET** /stages/authenticator/totp/ |  |
| [**stagesAuthenticatorTotpPartialUpdate()**](StagesApi.md#stagesAuthenticatorTotpPartialUpdate) | **PATCH** /stages/authenticator/totp/{stage_uuid}/ |  |
| [**stagesAuthenticatorTotpRetrieve()**](StagesApi.md#stagesAuthenticatorTotpRetrieve) | **GET** /stages/authenticator/totp/{stage_uuid}/ |  |
| [**stagesAuthenticatorTotpUpdate()**](StagesApi.md#stagesAuthenticatorTotpUpdate) | **PUT** /stages/authenticator/totp/{stage_uuid}/ |  |
| [**stagesAuthenticatorTotpUsedByList()**](StagesApi.md#stagesAuthenticatorTotpUsedByList) | **GET** /stages/authenticator/totp/{stage_uuid}/used_by/ |  |
| [**stagesAuthenticatorValidateCreate()**](StagesApi.md#stagesAuthenticatorValidateCreate) | **POST** /stages/authenticator/validate/ |  |
| [**stagesAuthenticatorValidateDestroy()**](StagesApi.md#stagesAuthenticatorValidateDestroy) | **DELETE** /stages/authenticator/validate/{stage_uuid}/ |  |
| [**stagesAuthenticatorValidateList()**](StagesApi.md#stagesAuthenticatorValidateList) | **GET** /stages/authenticator/validate/ |  |
| [**stagesAuthenticatorValidatePartialUpdate()**](StagesApi.md#stagesAuthenticatorValidatePartialUpdate) | **PATCH** /stages/authenticator/validate/{stage_uuid}/ |  |
| [**stagesAuthenticatorValidateRetrieve()**](StagesApi.md#stagesAuthenticatorValidateRetrieve) | **GET** /stages/authenticator/validate/{stage_uuid}/ |  |
| [**stagesAuthenticatorValidateUpdate()**](StagesApi.md#stagesAuthenticatorValidateUpdate) | **PUT** /stages/authenticator/validate/{stage_uuid}/ |  |
| [**stagesAuthenticatorValidateUsedByList()**](StagesApi.md#stagesAuthenticatorValidateUsedByList) | **GET** /stages/authenticator/validate/{stage_uuid}/used_by/ |  |
| [**stagesAuthenticatorWebauthnCreate()**](StagesApi.md#stagesAuthenticatorWebauthnCreate) | **POST** /stages/authenticator/webauthn/ |  |
| [**stagesAuthenticatorWebauthnDestroy()**](StagesApi.md#stagesAuthenticatorWebauthnDestroy) | **DELETE** /stages/authenticator/webauthn/{stage_uuid}/ |  |
| [**stagesAuthenticatorWebauthnDeviceTypesList()**](StagesApi.md#stagesAuthenticatorWebauthnDeviceTypesList) | **GET** /stages/authenticator/webauthn_device_types/ |  |
| [**stagesAuthenticatorWebauthnDeviceTypesRetrieve()**](StagesApi.md#stagesAuthenticatorWebauthnDeviceTypesRetrieve) | **GET** /stages/authenticator/webauthn_device_types/{aaguid}/ |  |
| [**stagesAuthenticatorWebauthnList()**](StagesApi.md#stagesAuthenticatorWebauthnList) | **GET** /stages/authenticator/webauthn/ |  |
| [**stagesAuthenticatorWebauthnPartialUpdate()**](StagesApi.md#stagesAuthenticatorWebauthnPartialUpdate) | **PATCH** /stages/authenticator/webauthn/{stage_uuid}/ |  |
| [**stagesAuthenticatorWebauthnRetrieve()**](StagesApi.md#stagesAuthenticatorWebauthnRetrieve) | **GET** /stages/authenticator/webauthn/{stage_uuid}/ |  |
| [**stagesAuthenticatorWebauthnUpdate()**](StagesApi.md#stagesAuthenticatorWebauthnUpdate) | **PUT** /stages/authenticator/webauthn/{stage_uuid}/ |  |
| [**stagesAuthenticatorWebauthnUsedByList()**](StagesApi.md#stagesAuthenticatorWebauthnUsedByList) | **GET** /stages/authenticator/webauthn/{stage_uuid}/used_by/ |  |
| [**stagesCaptchaCreate()**](StagesApi.md#stagesCaptchaCreate) | **POST** /stages/captcha/ |  |
| [**stagesCaptchaDestroy()**](StagesApi.md#stagesCaptchaDestroy) | **DELETE** /stages/captcha/{stage_uuid}/ |  |
| [**stagesCaptchaList()**](StagesApi.md#stagesCaptchaList) | **GET** /stages/captcha/ |  |
| [**stagesCaptchaPartialUpdate()**](StagesApi.md#stagesCaptchaPartialUpdate) | **PATCH** /stages/captcha/{stage_uuid}/ |  |
| [**stagesCaptchaRetrieve()**](StagesApi.md#stagesCaptchaRetrieve) | **GET** /stages/captcha/{stage_uuid}/ |  |
| [**stagesCaptchaUpdate()**](StagesApi.md#stagesCaptchaUpdate) | **PUT** /stages/captcha/{stage_uuid}/ |  |
| [**stagesCaptchaUsedByList()**](StagesApi.md#stagesCaptchaUsedByList) | **GET** /stages/captcha/{stage_uuid}/used_by/ |  |
| [**stagesConsentCreate()**](StagesApi.md#stagesConsentCreate) | **POST** /stages/consent/ |  |
| [**stagesConsentDestroy()**](StagesApi.md#stagesConsentDestroy) | **DELETE** /stages/consent/{stage_uuid}/ |  |
| [**stagesConsentList()**](StagesApi.md#stagesConsentList) | **GET** /stages/consent/ |  |
| [**stagesConsentPartialUpdate()**](StagesApi.md#stagesConsentPartialUpdate) | **PATCH** /stages/consent/{stage_uuid}/ |  |
| [**stagesConsentRetrieve()**](StagesApi.md#stagesConsentRetrieve) | **GET** /stages/consent/{stage_uuid}/ |  |
| [**stagesConsentUpdate()**](StagesApi.md#stagesConsentUpdate) | **PUT** /stages/consent/{stage_uuid}/ |  |
| [**stagesConsentUsedByList()**](StagesApi.md#stagesConsentUsedByList) | **GET** /stages/consent/{stage_uuid}/used_by/ |  |
| [**stagesDenyCreate()**](StagesApi.md#stagesDenyCreate) | **POST** /stages/deny/ |  |
| [**stagesDenyDestroy()**](StagesApi.md#stagesDenyDestroy) | **DELETE** /stages/deny/{stage_uuid}/ |  |
| [**stagesDenyList()**](StagesApi.md#stagesDenyList) | **GET** /stages/deny/ |  |
| [**stagesDenyPartialUpdate()**](StagesApi.md#stagesDenyPartialUpdate) | **PATCH** /stages/deny/{stage_uuid}/ |  |
| [**stagesDenyRetrieve()**](StagesApi.md#stagesDenyRetrieve) | **GET** /stages/deny/{stage_uuid}/ |  |
| [**stagesDenyUpdate()**](StagesApi.md#stagesDenyUpdate) | **PUT** /stages/deny/{stage_uuid}/ |  |
| [**stagesDenyUsedByList()**](StagesApi.md#stagesDenyUsedByList) | **GET** /stages/deny/{stage_uuid}/used_by/ |  |
| [**stagesDummyCreate()**](StagesApi.md#stagesDummyCreate) | **POST** /stages/dummy/ |  |
| [**stagesDummyDestroy()**](StagesApi.md#stagesDummyDestroy) | **DELETE** /stages/dummy/{stage_uuid}/ |  |
| [**stagesDummyList()**](StagesApi.md#stagesDummyList) | **GET** /stages/dummy/ |  |
| [**stagesDummyPartialUpdate()**](StagesApi.md#stagesDummyPartialUpdate) | **PATCH** /stages/dummy/{stage_uuid}/ |  |
| [**stagesDummyRetrieve()**](StagesApi.md#stagesDummyRetrieve) | **GET** /stages/dummy/{stage_uuid}/ |  |
| [**stagesDummyUpdate()**](StagesApi.md#stagesDummyUpdate) | **PUT** /stages/dummy/{stage_uuid}/ |  |
| [**stagesDummyUsedByList()**](StagesApi.md#stagesDummyUsedByList) | **GET** /stages/dummy/{stage_uuid}/used_by/ |  |
| [**stagesEmailCreate()**](StagesApi.md#stagesEmailCreate) | **POST** /stages/email/ |  |
| [**stagesEmailDestroy()**](StagesApi.md#stagesEmailDestroy) | **DELETE** /stages/email/{stage_uuid}/ |  |
| [**stagesEmailList()**](StagesApi.md#stagesEmailList) | **GET** /stages/email/ |  |
| [**stagesEmailPartialUpdate()**](StagesApi.md#stagesEmailPartialUpdate) | **PATCH** /stages/email/{stage_uuid}/ |  |
| [**stagesEmailRetrieve()**](StagesApi.md#stagesEmailRetrieve) | **GET** /stages/email/{stage_uuid}/ |  |
| [**stagesEmailTemplatesList()**](StagesApi.md#stagesEmailTemplatesList) | **GET** /stages/email/templates/ |  |
| [**stagesEmailUpdate()**](StagesApi.md#stagesEmailUpdate) | **PUT** /stages/email/{stage_uuid}/ |  |
| [**stagesEmailUsedByList()**](StagesApi.md#stagesEmailUsedByList) | **GET** /stages/email/{stage_uuid}/used_by/ |  |
| [**stagesEndpointsCreate()**](StagesApi.md#stagesEndpointsCreate) | **POST** /stages/endpoints/ |  |
| [**stagesEndpointsDestroy()**](StagesApi.md#stagesEndpointsDestroy) | **DELETE** /stages/endpoints/{stage_uuid}/ |  |
| [**stagesEndpointsList()**](StagesApi.md#stagesEndpointsList) | **GET** /stages/endpoints/ |  |
| [**stagesEndpointsPartialUpdate()**](StagesApi.md#stagesEndpointsPartialUpdate) | **PATCH** /stages/endpoints/{stage_uuid}/ |  |
| [**stagesEndpointsRetrieve()**](StagesApi.md#stagesEndpointsRetrieve) | **GET** /stages/endpoints/{stage_uuid}/ |  |
| [**stagesEndpointsUpdate()**](StagesApi.md#stagesEndpointsUpdate) | **PUT** /stages/endpoints/{stage_uuid}/ |  |
| [**stagesEndpointsUsedByList()**](StagesApi.md#stagesEndpointsUsedByList) | **GET** /stages/endpoints/{stage_uuid}/used_by/ |  |
| [**stagesIdentificationCreate()**](StagesApi.md#stagesIdentificationCreate) | **POST** /stages/identification/ |  |
| [**stagesIdentificationDestroy()**](StagesApi.md#stagesIdentificationDestroy) | **DELETE** /stages/identification/{stage_uuid}/ |  |
| [**stagesIdentificationList()**](StagesApi.md#stagesIdentificationList) | **GET** /stages/identification/ |  |
| [**stagesIdentificationPartialUpdate()**](StagesApi.md#stagesIdentificationPartialUpdate) | **PATCH** /stages/identification/{stage_uuid}/ |  |
| [**stagesIdentificationRetrieve()**](StagesApi.md#stagesIdentificationRetrieve) | **GET** /stages/identification/{stage_uuid}/ |  |
| [**stagesIdentificationUpdate()**](StagesApi.md#stagesIdentificationUpdate) | **PUT** /stages/identification/{stage_uuid}/ |  |
| [**stagesIdentificationUsedByList()**](StagesApi.md#stagesIdentificationUsedByList) | **GET** /stages/identification/{stage_uuid}/used_by/ |  |
| [**stagesInvitationInvitationsCreate()**](StagesApi.md#stagesInvitationInvitationsCreate) | **POST** /stages/invitation/invitations/ |  |
| [**stagesInvitationInvitationsDestroy()**](StagesApi.md#stagesInvitationInvitationsDestroy) | **DELETE** /stages/invitation/invitations/{invite_uuid}/ |  |
| [**stagesInvitationInvitationsList()**](StagesApi.md#stagesInvitationInvitationsList) | **GET** /stages/invitation/invitations/ |  |
| [**stagesInvitationInvitationsPartialUpdate()**](StagesApi.md#stagesInvitationInvitationsPartialUpdate) | **PATCH** /stages/invitation/invitations/{invite_uuid}/ |  |
| [**stagesInvitationInvitationsRetrieve()**](StagesApi.md#stagesInvitationInvitationsRetrieve) | **GET** /stages/invitation/invitations/{invite_uuid}/ |  |
| [**stagesInvitationInvitationsUpdate()**](StagesApi.md#stagesInvitationInvitationsUpdate) | **PUT** /stages/invitation/invitations/{invite_uuid}/ |  |
| [**stagesInvitationInvitationsUsedByList()**](StagesApi.md#stagesInvitationInvitationsUsedByList) | **GET** /stages/invitation/invitations/{invite_uuid}/used_by/ |  |
| [**stagesInvitationStagesCreate()**](StagesApi.md#stagesInvitationStagesCreate) | **POST** /stages/invitation/stages/ |  |
| [**stagesInvitationStagesDestroy()**](StagesApi.md#stagesInvitationStagesDestroy) | **DELETE** /stages/invitation/stages/{stage_uuid}/ |  |
| [**stagesInvitationStagesList()**](StagesApi.md#stagesInvitationStagesList) | **GET** /stages/invitation/stages/ |  |
| [**stagesInvitationStagesPartialUpdate()**](StagesApi.md#stagesInvitationStagesPartialUpdate) | **PATCH** /stages/invitation/stages/{stage_uuid}/ |  |
| [**stagesInvitationStagesRetrieve()**](StagesApi.md#stagesInvitationStagesRetrieve) | **GET** /stages/invitation/stages/{stage_uuid}/ |  |
| [**stagesInvitationStagesUpdate()**](StagesApi.md#stagesInvitationStagesUpdate) | **PUT** /stages/invitation/stages/{stage_uuid}/ |  |
| [**stagesInvitationStagesUsedByList()**](StagesApi.md#stagesInvitationStagesUsedByList) | **GET** /stages/invitation/stages/{stage_uuid}/used_by/ |  |
| [**stagesMtlsCreate()**](StagesApi.md#stagesMtlsCreate) | **POST** /stages/mtls/ |  |
| [**stagesMtlsDestroy()**](StagesApi.md#stagesMtlsDestroy) | **DELETE** /stages/mtls/{stage_uuid}/ |  |
| [**stagesMtlsList()**](StagesApi.md#stagesMtlsList) | **GET** /stages/mtls/ |  |
| [**stagesMtlsPartialUpdate()**](StagesApi.md#stagesMtlsPartialUpdate) | **PATCH** /stages/mtls/{stage_uuid}/ |  |
| [**stagesMtlsRetrieve()**](StagesApi.md#stagesMtlsRetrieve) | **GET** /stages/mtls/{stage_uuid}/ |  |
| [**stagesMtlsUpdate()**](StagesApi.md#stagesMtlsUpdate) | **PUT** /stages/mtls/{stage_uuid}/ |  |
| [**stagesMtlsUsedByList()**](StagesApi.md#stagesMtlsUsedByList) | **GET** /stages/mtls/{stage_uuid}/used_by/ |  |
| [**stagesPasswordCreate()**](StagesApi.md#stagesPasswordCreate) | **POST** /stages/password/ |  |
| [**stagesPasswordDestroy()**](StagesApi.md#stagesPasswordDestroy) | **DELETE** /stages/password/{stage_uuid}/ |  |
| [**stagesPasswordList()**](StagesApi.md#stagesPasswordList) | **GET** /stages/password/ |  |
| [**stagesPasswordPartialUpdate()**](StagesApi.md#stagesPasswordPartialUpdate) | **PATCH** /stages/password/{stage_uuid}/ |  |
| [**stagesPasswordRetrieve()**](StagesApi.md#stagesPasswordRetrieve) | **GET** /stages/password/{stage_uuid}/ |  |
| [**stagesPasswordUpdate()**](StagesApi.md#stagesPasswordUpdate) | **PUT** /stages/password/{stage_uuid}/ |  |
| [**stagesPasswordUsedByList()**](StagesApi.md#stagesPasswordUsedByList) | **GET** /stages/password/{stage_uuid}/used_by/ |  |
| [**stagesPromptPromptsCreate()**](StagesApi.md#stagesPromptPromptsCreate) | **POST** /stages/prompt/prompts/ |  |
| [**stagesPromptPromptsDestroy()**](StagesApi.md#stagesPromptPromptsDestroy) | **DELETE** /stages/prompt/prompts/{prompt_uuid}/ |  |
| [**stagesPromptPromptsList()**](StagesApi.md#stagesPromptPromptsList) | **GET** /stages/prompt/prompts/ |  |
| [**stagesPromptPromptsPartialUpdate()**](StagesApi.md#stagesPromptPromptsPartialUpdate) | **PATCH** /stages/prompt/prompts/{prompt_uuid}/ |  |
| [**stagesPromptPromptsPreviewCreate()**](StagesApi.md#stagesPromptPromptsPreviewCreate) | **POST** /stages/prompt/prompts/preview/ |  |
| [**stagesPromptPromptsRetrieve()**](StagesApi.md#stagesPromptPromptsRetrieve) | **GET** /stages/prompt/prompts/{prompt_uuid}/ |  |
| [**stagesPromptPromptsUpdate()**](StagesApi.md#stagesPromptPromptsUpdate) | **PUT** /stages/prompt/prompts/{prompt_uuid}/ |  |
| [**stagesPromptPromptsUsedByList()**](StagesApi.md#stagesPromptPromptsUsedByList) | **GET** /stages/prompt/prompts/{prompt_uuid}/used_by/ |  |
| [**stagesPromptStagesCreate()**](StagesApi.md#stagesPromptStagesCreate) | **POST** /stages/prompt/stages/ |  |
| [**stagesPromptStagesDestroy()**](StagesApi.md#stagesPromptStagesDestroy) | **DELETE** /stages/prompt/stages/{stage_uuid}/ |  |
| [**stagesPromptStagesList()**](StagesApi.md#stagesPromptStagesList) | **GET** /stages/prompt/stages/ |  |
| [**stagesPromptStagesPartialUpdate()**](StagesApi.md#stagesPromptStagesPartialUpdate) | **PATCH** /stages/prompt/stages/{stage_uuid}/ |  |
| [**stagesPromptStagesRetrieve()**](StagesApi.md#stagesPromptStagesRetrieve) | **GET** /stages/prompt/stages/{stage_uuid}/ |  |
| [**stagesPromptStagesUpdate()**](StagesApi.md#stagesPromptStagesUpdate) | **PUT** /stages/prompt/stages/{stage_uuid}/ |  |
| [**stagesPromptStagesUsedByList()**](StagesApi.md#stagesPromptStagesUsedByList) | **GET** /stages/prompt/stages/{stage_uuid}/used_by/ |  |
| [**stagesRedirectCreate()**](StagesApi.md#stagesRedirectCreate) | **POST** /stages/redirect/ |  |
| [**stagesRedirectDestroy()**](StagesApi.md#stagesRedirectDestroy) | **DELETE** /stages/redirect/{stage_uuid}/ |  |
| [**stagesRedirectList()**](StagesApi.md#stagesRedirectList) | **GET** /stages/redirect/ |  |
| [**stagesRedirectPartialUpdate()**](StagesApi.md#stagesRedirectPartialUpdate) | **PATCH** /stages/redirect/{stage_uuid}/ |  |
| [**stagesRedirectRetrieve()**](StagesApi.md#stagesRedirectRetrieve) | **GET** /stages/redirect/{stage_uuid}/ |  |
| [**stagesRedirectUpdate()**](StagesApi.md#stagesRedirectUpdate) | **PUT** /stages/redirect/{stage_uuid}/ |  |
| [**stagesRedirectUsedByList()**](StagesApi.md#stagesRedirectUsedByList) | **GET** /stages/redirect/{stage_uuid}/used_by/ |  |
| [**stagesSourceCreate()**](StagesApi.md#stagesSourceCreate) | **POST** /stages/source/ |  |
| [**stagesSourceDestroy()**](StagesApi.md#stagesSourceDestroy) | **DELETE** /stages/source/{stage_uuid}/ |  |
| [**stagesSourceList()**](StagesApi.md#stagesSourceList) | **GET** /stages/source/ |  |
| [**stagesSourcePartialUpdate()**](StagesApi.md#stagesSourcePartialUpdate) | **PATCH** /stages/source/{stage_uuid}/ |  |
| [**stagesSourceRetrieve()**](StagesApi.md#stagesSourceRetrieve) | **GET** /stages/source/{stage_uuid}/ |  |
| [**stagesSourceUpdate()**](StagesApi.md#stagesSourceUpdate) | **PUT** /stages/source/{stage_uuid}/ |  |
| [**stagesSourceUsedByList()**](StagesApi.md#stagesSourceUsedByList) | **GET** /stages/source/{stage_uuid}/used_by/ |  |
| [**stagesUserDeleteCreate()**](StagesApi.md#stagesUserDeleteCreate) | **POST** /stages/user_delete/ |  |
| [**stagesUserDeleteDestroy()**](StagesApi.md#stagesUserDeleteDestroy) | **DELETE** /stages/user_delete/{stage_uuid}/ |  |
| [**stagesUserDeleteList()**](StagesApi.md#stagesUserDeleteList) | **GET** /stages/user_delete/ |  |
| [**stagesUserDeletePartialUpdate()**](StagesApi.md#stagesUserDeletePartialUpdate) | **PATCH** /stages/user_delete/{stage_uuid}/ |  |
| [**stagesUserDeleteRetrieve()**](StagesApi.md#stagesUserDeleteRetrieve) | **GET** /stages/user_delete/{stage_uuid}/ |  |
| [**stagesUserDeleteUpdate()**](StagesApi.md#stagesUserDeleteUpdate) | **PUT** /stages/user_delete/{stage_uuid}/ |  |
| [**stagesUserDeleteUsedByList()**](StagesApi.md#stagesUserDeleteUsedByList) | **GET** /stages/user_delete/{stage_uuid}/used_by/ |  |
| [**stagesUserLoginCreate()**](StagesApi.md#stagesUserLoginCreate) | **POST** /stages/user_login/ |  |
| [**stagesUserLoginDestroy()**](StagesApi.md#stagesUserLoginDestroy) | **DELETE** /stages/user_login/{stage_uuid}/ |  |
| [**stagesUserLoginList()**](StagesApi.md#stagesUserLoginList) | **GET** /stages/user_login/ |  |
| [**stagesUserLoginPartialUpdate()**](StagesApi.md#stagesUserLoginPartialUpdate) | **PATCH** /stages/user_login/{stage_uuid}/ |  |
| [**stagesUserLoginRetrieve()**](StagesApi.md#stagesUserLoginRetrieve) | **GET** /stages/user_login/{stage_uuid}/ |  |
| [**stagesUserLoginUpdate()**](StagesApi.md#stagesUserLoginUpdate) | **PUT** /stages/user_login/{stage_uuid}/ |  |
| [**stagesUserLoginUsedByList()**](StagesApi.md#stagesUserLoginUsedByList) | **GET** /stages/user_login/{stage_uuid}/used_by/ |  |
| [**stagesUserLogoutCreate()**](StagesApi.md#stagesUserLogoutCreate) | **POST** /stages/user_logout/ |  |
| [**stagesUserLogoutDestroy()**](StagesApi.md#stagesUserLogoutDestroy) | **DELETE** /stages/user_logout/{stage_uuid}/ |  |
| [**stagesUserLogoutList()**](StagesApi.md#stagesUserLogoutList) | **GET** /stages/user_logout/ |  |
| [**stagesUserLogoutPartialUpdate()**](StagesApi.md#stagesUserLogoutPartialUpdate) | **PATCH** /stages/user_logout/{stage_uuid}/ |  |
| [**stagesUserLogoutRetrieve()**](StagesApi.md#stagesUserLogoutRetrieve) | **GET** /stages/user_logout/{stage_uuid}/ |  |
| [**stagesUserLogoutUpdate()**](StagesApi.md#stagesUserLogoutUpdate) | **PUT** /stages/user_logout/{stage_uuid}/ |  |
| [**stagesUserLogoutUsedByList()**](StagesApi.md#stagesUserLogoutUsedByList) | **GET** /stages/user_logout/{stage_uuid}/used_by/ |  |
| [**stagesUserWriteCreate()**](StagesApi.md#stagesUserWriteCreate) | **POST** /stages/user_write/ |  |
| [**stagesUserWriteDestroy()**](StagesApi.md#stagesUserWriteDestroy) | **DELETE** /stages/user_write/{stage_uuid}/ |  |
| [**stagesUserWriteList()**](StagesApi.md#stagesUserWriteList) | **GET** /stages/user_write/ |  |
| [**stagesUserWritePartialUpdate()**](StagesApi.md#stagesUserWritePartialUpdate) | **PATCH** /stages/user_write/{stage_uuid}/ |  |
| [**stagesUserWriteRetrieve()**](StagesApi.md#stagesUserWriteRetrieve) | **GET** /stages/user_write/{stage_uuid}/ |  |
| [**stagesUserWriteUpdate()**](StagesApi.md#stagesUserWriteUpdate) | **PUT** /stages/user_write/{stage_uuid}/ |  |
| [**stagesUserWriteUsedByList()**](StagesApi.md#stagesUserWriteUsedByList) | **GET** /stages/user_write/{stage_uuid}/used_by/ |  |


## `stagesAllDestroy()`

```php
stagesAllDestroy($stage_uuid)
```



Stage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this stage.

try {
    $apiInstance->stagesAllDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAllDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAllList()`

```php
stagesAllList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedStageList
```



Stage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->stagesAllList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAllList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedStageList**](../Model/PaginatedStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAllRetrieve()`

```php
stagesAllRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Stage
```



Stage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this stage.

try {
    $result = $apiInstance->stagesAllRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAllRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Stage**](../Model/Stage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAllTypesList()`

```php
stagesAllTypesList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TypeCreate[]
```



Get all creatable types

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->stagesAllTypesList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAllTypesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TypeCreate[]**](../Model/TypeCreate.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAllUsedByList()`

```php
stagesAllUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this stage.

try {
    $result = $apiInstance->stagesAllUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAllUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAllUserSettingsList()`

```php
stagesAllUserSettingsList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserSetting[]
```



Get all stages the user can configure

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->stagesAllUserSettingsList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAllUserSettingsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserSetting[]**](../Model/UserSetting.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorDuoCreate()`

```php
stagesAuthenticatorDuoCreate($authenticator_duo_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStage
```



AuthenticatorDuoStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$authenticator_duo_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorDuoCreate($authenticator_duo_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorDuoCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **authenticator_duo_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStageRequest**](../Model/AuthenticatorDuoStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStage**](../Model/AuthenticatorDuoStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorDuoDestroy()`

```php
stagesAuthenticatorDuoDestroy($stage_uuid)
```



AuthenticatorDuoStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Duo Authenticator Setup Stage.

try {
    $apiInstance->stagesAuthenticatorDuoDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorDuoDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Duo Authenticator Setup Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorDuoEnrollmentStatusCreate()`

```php
stagesAuthenticatorDuoEnrollmentStatusCreate($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDeviceEnrollmentStatus
```



Check enrollment status of user details in current session

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');



$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Duo Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorDuoEnrollmentStatusCreate($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorDuoEnrollmentStatusCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Duo Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDeviceEnrollmentStatus**](../Model/DuoDeviceEnrollmentStatus.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorDuoImportDeviceManualCreate()`

```php
stagesAuthenticatorDuoImportDeviceManualCreate($stage_uuid, $authenticator_duo_stage_manual_device_import_request)
```



Import duo devices into authentik

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Duo Authenticator Setup Stage.
$authenticator_duo_stage_manual_device_import_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStageManualDeviceImportRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStageManualDeviceImportRequest

try {
    $apiInstance->stagesAuthenticatorDuoImportDeviceManualCreate($stage_uuid, $authenticator_duo_stage_manual_device_import_request);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorDuoImportDeviceManualCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Duo Authenticator Setup Stage. | |
| **authenticator_duo_stage_manual_device_import_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStageManualDeviceImportRequest**](../Model/AuthenticatorDuoStageManualDeviceImportRequest.md)|  | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorDuoImportDevicesAutomaticCreate()`

```php
stagesAuthenticatorDuoImportDevicesAutomaticCreate($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStageDeviceImportResponse
```



Import duo devices into authentik

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Duo Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorDuoImportDevicesAutomaticCreate($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorDuoImportDevicesAutomaticCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Duo Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStageDeviceImportResponse**](../Model/AuthenticatorDuoStageDeviceImportResponse.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorDuoList()`

```php
stagesAuthenticatorDuoList($api_hostname, $client_id, $configure_flow, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorDuoStageList
```



AuthenticatorDuoStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$api_hostname = 'api_hostname_example'; // string
$client_id = 'client_id_example'; // string
$configure_flow = 'configure_flow_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->stagesAuthenticatorDuoList($api_hostname, $client_id, $configure_flow, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorDuoList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **api_hostname** | **string**|  | [optional] |
| **client_id** | **string**|  | [optional] |
| **configure_flow** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorDuoStageList**](../Model/PaginatedAuthenticatorDuoStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorDuoPartialUpdate()`

```php
stagesAuthenticatorDuoPartialUpdate($stage_uuid, $patched_authenticator_duo_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStage
```



AuthenticatorDuoStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Duo Authenticator Setup Stage.
$patched_authenticator_duo_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorDuoStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorDuoStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorDuoPartialUpdate($stage_uuid, $patched_authenticator_duo_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorDuoPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Duo Authenticator Setup Stage. | |
| **patched_authenticator_duo_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorDuoStageRequest**](../Model/PatchedAuthenticatorDuoStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStage**](../Model/AuthenticatorDuoStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorDuoRetrieve()`

```php
stagesAuthenticatorDuoRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStage
```



AuthenticatorDuoStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Duo Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorDuoRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorDuoRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Duo Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStage**](../Model/AuthenticatorDuoStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorDuoUpdate()`

```php
stagesAuthenticatorDuoUpdate($stage_uuid, $authenticator_duo_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStage
```



AuthenticatorDuoStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Duo Authenticator Setup Stage.
$authenticator_duo_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorDuoUpdate($stage_uuid, $authenticator_duo_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorDuoUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Duo Authenticator Setup Stage. | |
| **authenticator_duo_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStageRequest**](../Model/AuthenticatorDuoStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorDuoStage**](../Model/AuthenticatorDuoStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorDuoUsedByList()`

```php
stagesAuthenticatorDuoUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Duo Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorDuoUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorDuoUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Duo Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEmailCreate()`

```php
stagesAuthenticatorEmailCreate($authenticator_email_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStage
```



AuthenticatorEmailStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$authenticator_email_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorEmailCreate($authenticator_email_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEmailCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **authenticator_email_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStageRequest**](../Model/AuthenticatorEmailStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStage**](../Model/AuthenticatorEmailStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEmailDestroy()`

```php
stagesAuthenticatorEmailDestroy($stage_uuid)
```



AuthenticatorEmailStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Email Authenticator Setup Stage.

try {
    $apiInstance->stagesAuthenticatorEmailDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEmailDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Email Authenticator Setup Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEmailList()`

```php
stagesAuthenticatorEmailList($configure_flow, $friendly_name, $from_address, $host, $name, $ordering, $page, $page_size, $password, $port, $search, $stage_uuid, $subject, $template, $timeout, $token_expiry, $use_global_settings, $use_ssl, $use_tls, $username): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorEmailStageList
```



AuthenticatorEmailStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$configure_flow = 'configure_flow_example'; // string
$friendly_name = 'friendly_name_example'; // string
$from_address = 'from_address_example'; // string
$host = 'host_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$password = 'password_example'; // string
$port = 56; // int
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string
$subject = 'subject_example'; // string
$template = 'template_example'; // string
$timeout = 56; // int
$token_expiry = 'token_expiry_example'; // string
$use_global_settings = True; // bool
$use_ssl = True; // bool
$use_tls = True; // bool
$username = 'username_example'; // string

try {
    $result = $apiInstance->stagesAuthenticatorEmailList($configure_flow, $friendly_name, $from_address, $host, $name, $ordering, $page, $page_size, $password, $port, $search, $stage_uuid, $subject, $template, $timeout, $token_expiry, $use_global_settings, $use_ssl, $use_tls, $username);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEmailList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **configure_flow** | **string**|  | [optional] |
| **friendly_name** | **string**|  | [optional] |
| **from_address** | **string**|  | [optional] |
| **host** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **password** | **string**|  | [optional] |
| **port** | **int**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |
| **subject** | **string**|  | [optional] |
| **template** | **string**|  | [optional] |
| **timeout** | **int**|  | [optional] |
| **token_expiry** | **string**|  | [optional] |
| **use_global_settings** | **bool**|  | [optional] |
| **use_ssl** | **bool**|  | [optional] |
| **use_tls** | **bool**|  | [optional] |
| **username** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorEmailStageList**](../Model/PaginatedAuthenticatorEmailStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEmailPartialUpdate()`

```php
stagesAuthenticatorEmailPartialUpdate($stage_uuid, $patched_authenticator_email_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStage
```



AuthenticatorEmailStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Email Authenticator Setup Stage.
$patched_authenticator_email_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorEmailStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorEmailStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorEmailPartialUpdate($stage_uuid, $patched_authenticator_email_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEmailPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Email Authenticator Setup Stage. | |
| **patched_authenticator_email_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorEmailStageRequest**](../Model/PatchedAuthenticatorEmailStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStage**](../Model/AuthenticatorEmailStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEmailRetrieve()`

```php
stagesAuthenticatorEmailRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStage
```



AuthenticatorEmailStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Email Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorEmailRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEmailRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Email Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStage**](../Model/AuthenticatorEmailStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEmailUpdate()`

```php
stagesAuthenticatorEmailUpdate($stage_uuid, $authenticator_email_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStage
```



AuthenticatorEmailStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Email Authenticator Setup Stage.
$authenticator_email_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorEmailUpdate($stage_uuid, $authenticator_email_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEmailUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Email Authenticator Setup Stage. | |
| **authenticator_email_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStageRequest**](../Model/AuthenticatorEmailStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEmailStage**](../Model/AuthenticatorEmailStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEmailUsedByList()`

```php
stagesAuthenticatorEmailUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Email Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorEmailUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEmailUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Email Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEndpointGdtcCreate()`

```php
stagesAuthenticatorEndpointGdtcCreate($authenticator_endpoint_gdtc_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStage
```



AuthenticatorEndpointGDTCStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$authenticator_endpoint_gdtc_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorEndpointGdtcCreate($authenticator_endpoint_gdtc_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEndpointGdtcCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **authenticator_endpoint_gdtc_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStageRequest**](../Model/AuthenticatorEndpointGDTCStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStage**](../Model/AuthenticatorEndpointGDTCStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEndpointGdtcDestroy()`

```php
stagesAuthenticatorEndpointGdtcDestroy($stage_uuid)
```



AuthenticatorEndpointGDTCStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Endpoint Authenticator Google Device Trust Connector Stage.

try {
    $apiInstance->stagesAuthenticatorEndpointGdtcDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEndpointGdtcDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Endpoint Authenticator Google Device Trust Connector Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEndpointGdtcList()`

```php
stagesAuthenticatorEndpointGdtcList($configure_flow, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorEndpointGDTCStageList
```



AuthenticatorEndpointGDTCStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$configure_flow = 'configure_flow_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->stagesAuthenticatorEndpointGdtcList($configure_flow, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEndpointGdtcList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **configure_flow** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorEndpointGDTCStageList**](../Model/PaginatedAuthenticatorEndpointGDTCStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEndpointGdtcPartialUpdate()`

```php
stagesAuthenticatorEndpointGdtcPartialUpdate($stage_uuid, $patched_authenticator_endpoint_gdtc_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStage
```



AuthenticatorEndpointGDTCStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Endpoint Authenticator Google Device Trust Connector Stage.
$patched_authenticator_endpoint_gdtc_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorEndpointGDTCStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorEndpointGDTCStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorEndpointGdtcPartialUpdate($stage_uuid, $patched_authenticator_endpoint_gdtc_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEndpointGdtcPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Endpoint Authenticator Google Device Trust Connector Stage. | |
| **patched_authenticator_endpoint_gdtc_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorEndpointGDTCStageRequest**](../Model/PatchedAuthenticatorEndpointGDTCStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStage**](../Model/AuthenticatorEndpointGDTCStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEndpointGdtcRetrieve()`

```php
stagesAuthenticatorEndpointGdtcRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStage
```



AuthenticatorEndpointGDTCStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Endpoint Authenticator Google Device Trust Connector Stage.

try {
    $result = $apiInstance->stagesAuthenticatorEndpointGdtcRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEndpointGdtcRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Endpoint Authenticator Google Device Trust Connector Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStage**](../Model/AuthenticatorEndpointGDTCStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEndpointGdtcUpdate()`

```php
stagesAuthenticatorEndpointGdtcUpdate($stage_uuid, $authenticator_endpoint_gdtc_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStage
```



AuthenticatorEndpointGDTCStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Endpoint Authenticator Google Device Trust Connector Stage.
$authenticator_endpoint_gdtc_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorEndpointGdtcUpdate($stage_uuid, $authenticator_endpoint_gdtc_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEndpointGdtcUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Endpoint Authenticator Google Device Trust Connector Stage. | |
| **authenticator_endpoint_gdtc_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStageRequest**](../Model/AuthenticatorEndpointGDTCStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorEndpointGDTCStage**](../Model/AuthenticatorEndpointGDTCStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorEndpointGdtcUsedByList()`

```php
stagesAuthenticatorEndpointGdtcUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Endpoint Authenticator Google Device Trust Connector Stage.

try {
    $result = $apiInstance->stagesAuthenticatorEndpointGdtcUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorEndpointGdtcUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Endpoint Authenticator Google Device Trust Connector Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorSmsCreate()`

```php
stagesAuthenticatorSmsCreate($authenticator_sms_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStage
```



AuthenticatorSMSStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$authenticator_sms_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorSmsCreate($authenticator_sms_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorSmsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **authenticator_sms_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStageRequest**](../Model/AuthenticatorSMSStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStage**](../Model/AuthenticatorSMSStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorSmsDestroy()`

```php
stagesAuthenticatorSmsDestroy($stage_uuid)
```



AuthenticatorSMSStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this SMS Authenticator Setup Stage.

try {
    $apiInstance->stagesAuthenticatorSmsDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorSmsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this SMS Authenticator Setup Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorSmsList()`

```php
stagesAuthenticatorSmsList($account_sid, $auth, $auth_password, $auth_type, $configure_flow, $friendly_name, $from_number, $mapping, $name, $ordering, $page, $page_size, $provider, $search, $stage_uuid, $verify_only): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorSMSStageList
```



AuthenticatorSMSStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$account_sid = 'account_sid_example'; // string
$auth = 'auth_example'; // string
$auth_password = 'auth_password_example'; // string
$auth_type = 'auth_type_example'; // string
$configure_flow = 'configure_flow_example'; // string
$friendly_name = 'friendly_name_example'; // string
$from_number = 'from_number_example'; // string
$mapping = 'mapping_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$provider = 'provider_example'; // string
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string
$verify_only = True; // bool

try {
    $result = $apiInstance->stagesAuthenticatorSmsList($account_sid, $auth, $auth_password, $auth_type, $configure_flow, $friendly_name, $from_number, $mapping, $name, $ordering, $page, $page_size, $provider, $search, $stage_uuid, $verify_only);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorSmsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **account_sid** | **string**|  | [optional] |
| **auth** | **string**|  | [optional] |
| **auth_password** | **string**|  | [optional] |
| **auth_type** | **string**|  | [optional] |
| **configure_flow** | **string**|  | [optional] |
| **friendly_name** | **string**|  | [optional] |
| **from_number** | **string**|  | [optional] |
| **mapping** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **provider** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |
| **verify_only** | **bool**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorSMSStageList**](../Model/PaginatedAuthenticatorSMSStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorSmsPartialUpdate()`

```php
stagesAuthenticatorSmsPartialUpdate($stage_uuid, $patched_authenticator_sms_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStage
```



AuthenticatorSMSStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this SMS Authenticator Setup Stage.
$patched_authenticator_sms_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorSMSStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorSMSStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorSmsPartialUpdate($stage_uuid, $patched_authenticator_sms_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorSmsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this SMS Authenticator Setup Stage. | |
| **patched_authenticator_sms_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorSMSStageRequest**](../Model/PatchedAuthenticatorSMSStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStage**](../Model/AuthenticatorSMSStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorSmsRetrieve()`

```php
stagesAuthenticatorSmsRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStage
```



AuthenticatorSMSStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this SMS Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorSmsRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorSmsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this SMS Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStage**](../Model/AuthenticatorSMSStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorSmsUpdate()`

```php
stagesAuthenticatorSmsUpdate($stage_uuid, $authenticator_sms_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStage
```



AuthenticatorSMSStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this SMS Authenticator Setup Stage.
$authenticator_sms_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorSmsUpdate($stage_uuid, $authenticator_sms_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorSmsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this SMS Authenticator Setup Stage. | |
| **authenticator_sms_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStageRequest**](../Model/AuthenticatorSMSStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorSMSStage**](../Model/AuthenticatorSMSStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorSmsUsedByList()`

```php
stagesAuthenticatorSmsUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this SMS Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorSmsUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorSmsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this SMS Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorStaticCreate()`

```php
stagesAuthenticatorStaticCreate($authenticator_static_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStage
```



AuthenticatorStaticStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$authenticator_static_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorStaticCreate($authenticator_static_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorStaticCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **authenticator_static_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStageRequest**](../Model/AuthenticatorStaticStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStage**](../Model/AuthenticatorStaticStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorStaticDestroy()`

```php
stagesAuthenticatorStaticDestroy($stage_uuid)
```



AuthenticatorStaticStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Static Authenticator Setup Stage.

try {
    $apiInstance->stagesAuthenticatorStaticDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorStaticDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Static Authenticator Setup Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorStaticList()`

```php
stagesAuthenticatorStaticList($configure_flow, $friendly_name, $name, $ordering, $page, $page_size, $search, $stage_uuid, $token_count, $token_length): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorStaticStageList
```



AuthenticatorStaticStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$configure_flow = 'configure_flow_example'; // string
$friendly_name = 'friendly_name_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string
$token_count = 56; // int
$token_length = 56; // int

try {
    $result = $apiInstance->stagesAuthenticatorStaticList($configure_flow, $friendly_name, $name, $ordering, $page, $page_size, $search, $stage_uuid, $token_count, $token_length);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorStaticList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **configure_flow** | **string**|  | [optional] |
| **friendly_name** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |
| **token_count** | **int**|  | [optional] |
| **token_length** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorStaticStageList**](../Model/PaginatedAuthenticatorStaticStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorStaticPartialUpdate()`

```php
stagesAuthenticatorStaticPartialUpdate($stage_uuid, $patched_authenticator_static_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStage
```



AuthenticatorStaticStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Static Authenticator Setup Stage.
$patched_authenticator_static_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorStaticStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorStaticStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorStaticPartialUpdate($stage_uuid, $patched_authenticator_static_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorStaticPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Static Authenticator Setup Stage. | |
| **patched_authenticator_static_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorStaticStageRequest**](../Model/PatchedAuthenticatorStaticStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStage**](../Model/AuthenticatorStaticStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorStaticRetrieve()`

```php
stagesAuthenticatorStaticRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStage
```



AuthenticatorStaticStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Static Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorStaticRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorStaticRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Static Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStage**](../Model/AuthenticatorStaticStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorStaticUpdate()`

```php
stagesAuthenticatorStaticUpdate($stage_uuid, $authenticator_static_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStage
```



AuthenticatorStaticStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Static Authenticator Setup Stage.
$authenticator_static_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorStaticUpdate($stage_uuid, $authenticator_static_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorStaticUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Static Authenticator Setup Stage. | |
| **authenticator_static_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStageRequest**](../Model/AuthenticatorStaticStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorStaticStage**](../Model/AuthenticatorStaticStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorStaticUsedByList()`

```php
stagesAuthenticatorStaticUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Static Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorStaticUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorStaticUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Static Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorTotpCreate()`

```php
stagesAuthenticatorTotpCreate($authenticator_totp_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStage
```



AuthenticatorTOTPStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$authenticator_totp_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorTotpCreate($authenticator_totp_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorTotpCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **authenticator_totp_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStageRequest**](../Model/AuthenticatorTOTPStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStage**](../Model/AuthenticatorTOTPStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorTotpDestroy()`

```php
stagesAuthenticatorTotpDestroy($stage_uuid)
```



AuthenticatorTOTPStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this TOTP Authenticator Setup Stage.

try {
    $apiInstance->stagesAuthenticatorTotpDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorTotpDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this TOTP Authenticator Setup Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorTotpList()`

```php
stagesAuthenticatorTotpList($configure_flow, $digits, $friendly_name, $name, $ordering, $page, $page_size, $search, $stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorTOTPStageList
```



AuthenticatorTOTPStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$configure_flow = 'configure_flow_example'; // string
$digits = 'digits_example'; // string
$friendly_name = 'friendly_name_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string

try {
    $result = $apiInstance->stagesAuthenticatorTotpList($configure_flow, $digits, $friendly_name, $name, $ordering, $page, $page_size, $search, $stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorTotpList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **configure_flow** | **string**|  | [optional] |
| **digits** | **string**|  | [optional] |
| **friendly_name** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorTOTPStageList**](../Model/PaginatedAuthenticatorTOTPStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorTotpPartialUpdate()`

```php
stagesAuthenticatorTotpPartialUpdate($stage_uuid, $patched_authenticator_totp_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStage
```



AuthenticatorTOTPStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this TOTP Authenticator Setup Stage.
$patched_authenticator_totp_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorTOTPStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorTOTPStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorTotpPartialUpdate($stage_uuid, $patched_authenticator_totp_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorTotpPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this TOTP Authenticator Setup Stage. | |
| **patched_authenticator_totp_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorTOTPStageRequest**](../Model/PatchedAuthenticatorTOTPStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStage**](../Model/AuthenticatorTOTPStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorTotpRetrieve()`

```php
stagesAuthenticatorTotpRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStage
```



AuthenticatorTOTPStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this TOTP Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorTotpRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorTotpRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this TOTP Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStage**](../Model/AuthenticatorTOTPStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorTotpUpdate()`

```php
stagesAuthenticatorTotpUpdate($stage_uuid, $authenticator_totp_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStage
```



AuthenticatorTOTPStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this TOTP Authenticator Setup Stage.
$authenticator_totp_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorTotpUpdate($stage_uuid, $authenticator_totp_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorTotpUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this TOTP Authenticator Setup Stage. | |
| **authenticator_totp_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStageRequest**](../Model/AuthenticatorTOTPStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorTOTPStage**](../Model/AuthenticatorTOTPStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorTotpUsedByList()`

```php
stagesAuthenticatorTotpUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this TOTP Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorTotpUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorTotpUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this TOTP Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorValidateCreate()`

```php
stagesAuthenticatorValidateCreate($authenticator_validate_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStage
```



AuthenticatorValidateStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$authenticator_validate_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorValidateCreate($authenticator_validate_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorValidateCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **authenticator_validate_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStageRequest**](../Model/AuthenticatorValidateStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStage**](../Model/AuthenticatorValidateStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorValidateDestroy()`

```php
stagesAuthenticatorValidateDestroy($stage_uuid)
```



AuthenticatorValidateStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Authenticator Validation Stage.

try {
    $apiInstance->stagesAuthenticatorValidateDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorValidateDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Authenticator Validation Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorValidateList()`

```php
stagesAuthenticatorValidateList($configuration_stages, $name, $not_configured_action, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorValidateStageList
```



AuthenticatorValidateStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$configuration_stages = array('configuration_stages_example'); // string[]
$name = 'name_example'; // string
$not_configured_action = 'not_configured_action_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->stagesAuthenticatorValidateList($configuration_stages, $name, $not_configured_action, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorValidateList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **configuration_stages** | [**string[]**](../Model/string.md)|  | [optional] |
| **name** | **string**|  | [optional] |
| **not_configured_action** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorValidateStageList**](../Model/PaginatedAuthenticatorValidateStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorValidatePartialUpdate()`

```php
stagesAuthenticatorValidatePartialUpdate($stage_uuid, $patched_authenticator_validate_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStage
```



AuthenticatorValidateStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Authenticator Validation Stage.
$patched_authenticator_validate_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorValidateStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorValidateStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorValidatePartialUpdate($stage_uuid, $patched_authenticator_validate_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorValidatePartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Authenticator Validation Stage. | |
| **patched_authenticator_validate_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorValidateStageRequest**](../Model/PatchedAuthenticatorValidateStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStage**](../Model/AuthenticatorValidateStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorValidateRetrieve()`

```php
stagesAuthenticatorValidateRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStage
```



AuthenticatorValidateStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Authenticator Validation Stage.

try {
    $result = $apiInstance->stagesAuthenticatorValidateRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorValidateRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Authenticator Validation Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStage**](../Model/AuthenticatorValidateStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorValidateUpdate()`

```php
stagesAuthenticatorValidateUpdate($stage_uuid, $authenticator_validate_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStage
```



AuthenticatorValidateStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Authenticator Validation Stage.
$authenticator_validate_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorValidateUpdate($stage_uuid, $authenticator_validate_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorValidateUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Authenticator Validation Stage. | |
| **authenticator_validate_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStageRequest**](../Model/AuthenticatorValidateStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorValidateStage**](../Model/AuthenticatorValidateStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorValidateUsedByList()`

```php
stagesAuthenticatorValidateUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Authenticator Validation Stage.

try {
    $result = $apiInstance->stagesAuthenticatorValidateUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorValidateUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Authenticator Validation Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorWebauthnCreate()`

```php
stagesAuthenticatorWebauthnCreate($authenticator_web_authn_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStage
```



AuthenticatorWebAuthnStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$authenticator_web_authn_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorWebauthnCreate($authenticator_web_authn_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorWebauthnCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **authenticator_web_authn_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStageRequest**](../Model/AuthenticatorWebAuthnStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStage**](../Model/AuthenticatorWebAuthnStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorWebauthnDestroy()`

```php
stagesAuthenticatorWebauthnDestroy($stage_uuid)
```



AuthenticatorWebAuthnStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this WebAuthn Authenticator Setup Stage.

try {
    $apiInstance->stagesAuthenticatorWebauthnDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorWebauthnDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this WebAuthn Authenticator Setup Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorWebauthnDeviceTypesList()`

```php
stagesAuthenticatorWebauthnDeviceTypesList($aaguid, $description, $icon, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedWebAuthnDeviceTypeList
```



WebAuthnDeviceType Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$aaguid = 'aaguid_example'; // string
$description = 'description_example'; // string
$icon = 'icon_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->stagesAuthenticatorWebauthnDeviceTypesList($aaguid, $description, $icon, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorWebauthnDeviceTypesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **aaguid** | **string**|  | [optional] |
| **description** | **string**|  | [optional] |
| **icon** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedWebAuthnDeviceTypeList**](../Model/PaginatedWebAuthnDeviceTypeList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorWebauthnDeviceTypesRetrieve()`

```php
stagesAuthenticatorWebauthnDeviceTypesRetrieve($aaguid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDeviceType
```



WebAuthnDeviceType Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$aaguid = 'aaguid_example'; // string | A UUID string identifying this WebAuthn Device type.

try {
    $result = $apiInstance->stagesAuthenticatorWebauthnDeviceTypesRetrieve($aaguid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorWebauthnDeviceTypesRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **aaguid** | **string**| A UUID string identifying this WebAuthn Device type. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDeviceType**](../Model/WebAuthnDeviceType.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorWebauthnList()`

```php
stagesAuthenticatorWebauthnList($authenticator_attachment, $configure_flow, $device_type_restrictions, $friendly_name, $max_attempts, $name, $ordering, $page, $page_size, $resident_key_requirement, $search, $stage_uuid, $user_verification): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorWebAuthnStageList
```



AuthenticatorWebAuthnStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$authenticator_attachment = 'authenticator_attachment_example'; // string
$configure_flow = 'configure_flow_example'; // string
$device_type_restrictions = array('device_type_restrictions_example'); // string[]
$friendly_name = 'friendly_name_example'; // string
$max_attempts = 56; // int
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$resident_key_requirement = 'resident_key_requirement_example'; // string
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string
$user_verification = 'user_verification_example'; // string

try {
    $result = $apiInstance->stagesAuthenticatorWebauthnList($authenticator_attachment, $configure_flow, $device_type_restrictions, $friendly_name, $max_attempts, $name, $ordering, $page, $page_size, $resident_key_requirement, $search, $stage_uuid, $user_verification);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorWebauthnList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **authenticator_attachment** | **string**|  | [optional] |
| **configure_flow** | **string**|  | [optional] |
| **device_type_restrictions** | [**string[]**](../Model/string.md)|  | [optional] |
| **friendly_name** | **string**|  | [optional] |
| **max_attempts** | **int**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **resident_key_requirement** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |
| **user_verification** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatorWebAuthnStageList**](../Model/PaginatedAuthenticatorWebAuthnStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorWebauthnPartialUpdate()`

```php
stagesAuthenticatorWebauthnPartialUpdate($stage_uuid, $patched_authenticator_web_authn_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStage
```



AuthenticatorWebAuthnStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this WebAuthn Authenticator Setup Stage.
$patched_authenticator_web_authn_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorWebAuthnStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorWebAuthnStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorWebauthnPartialUpdate($stage_uuid, $patched_authenticator_web_authn_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorWebauthnPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this WebAuthn Authenticator Setup Stage. | |
| **patched_authenticator_web_authn_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAuthenticatorWebAuthnStageRequest**](../Model/PatchedAuthenticatorWebAuthnStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStage**](../Model/AuthenticatorWebAuthnStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorWebauthnRetrieve()`

```php
stagesAuthenticatorWebauthnRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStage
```



AuthenticatorWebAuthnStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this WebAuthn Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorWebauthnRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorWebauthnRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this WebAuthn Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStage**](../Model/AuthenticatorWebAuthnStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorWebauthnUpdate()`

```php
stagesAuthenticatorWebauthnUpdate($stage_uuid, $authenticator_web_authn_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStage
```



AuthenticatorWebAuthnStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this WebAuthn Authenticator Setup Stage.
$authenticator_web_authn_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStageRequest

try {
    $result = $apiInstance->stagesAuthenticatorWebauthnUpdate($stage_uuid, $authenticator_web_authn_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorWebauthnUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this WebAuthn Authenticator Setup Stage. | |
| **authenticator_web_authn_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStageRequest**](../Model/AuthenticatorWebAuthnStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorWebAuthnStage**](../Model/AuthenticatorWebAuthnStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesAuthenticatorWebauthnUsedByList()`

```php
stagesAuthenticatorWebauthnUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this WebAuthn Authenticator Setup Stage.

try {
    $result = $apiInstance->stagesAuthenticatorWebauthnUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesAuthenticatorWebauthnUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this WebAuthn Authenticator Setup Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesCaptchaCreate()`

```php
stagesCaptchaCreate($captcha_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStage
```



CaptchaStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$captcha_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStageRequest

try {
    $result = $apiInstance->stagesCaptchaCreate($captcha_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesCaptchaCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **captcha_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStageRequest**](../Model/CaptchaStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStage**](../Model/CaptchaStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesCaptchaDestroy()`

```php
stagesCaptchaDestroy($stage_uuid)
```



CaptchaStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Captcha Stage.

try {
    $apiInstance->stagesCaptchaDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesCaptchaDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Captcha Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesCaptchaList()`

```php
stagesCaptchaList($name, $ordering, $page, $page_size, $public_key, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedCaptchaStageList
```



CaptchaStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$public_key = 'public_key_example'; // string
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->stagesCaptchaList($name, $ordering, $page, $page_size, $public_key, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesCaptchaList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **public_key** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedCaptchaStageList**](../Model/PaginatedCaptchaStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesCaptchaPartialUpdate()`

```php
stagesCaptchaPartialUpdate($stage_uuid, $patched_captcha_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStage
```



CaptchaStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Captcha Stage.
$patched_captcha_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedCaptchaStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedCaptchaStageRequest

try {
    $result = $apiInstance->stagesCaptchaPartialUpdate($stage_uuid, $patched_captcha_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesCaptchaPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Captcha Stage. | |
| **patched_captcha_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedCaptchaStageRequest**](../Model/PatchedCaptchaStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStage**](../Model/CaptchaStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesCaptchaRetrieve()`

```php
stagesCaptchaRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStage
```



CaptchaStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Captcha Stage.

try {
    $result = $apiInstance->stagesCaptchaRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesCaptchaRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Captcha Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStage**](../Model/CaptchaStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesCaptchaUpdate()`

```php
stagesCaptchaUpdate($stage_uuid, $captcha_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStage
```



CaptchaStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Captcha Stage.
$captcha_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStageRequest

try {
    $result = $apiInstance->stagesCaptchaUpdate($stage_uuid, $captcha_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesCaptchaUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Captcha Stage. | |
| **captcha_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStageRequest**](../Model/CaptchaStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaStage**](../Model/CaptchaStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesCaptchaUsedByList()`

```php
stagesCaptchaUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Captcha Stage.

try {
    $result = $apiInstance->stagesCaptchaUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesCaptchaUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Captcha Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesConsentCreate()`

```php
stagesConsentCreate($consent_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStage
```



ConsentStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$consent_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStageRequest

try {
    $result = $apiInstance->stagesConsentCreate($consent_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesConsentCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **consent_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStageRequest**](../Model/ConsentStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStage**](../Model/ConsentStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesConsentDestroy()`

```php
stagesConsentDestroy($stage_uuid)
```



ConsentStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Consent Stage.

try {
    $apiInstance->stagesConsentDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesConsentDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Consent Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesConsentList()`

```php
stagesConsentList($consent_expire_in, $mode, $name, $ordering, $page, $page_size, $search, $stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedConsentStageList
```



ConsentStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$consent_expire_in = 'consent_expire_in_example'; // string
$mode = 'mode_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string

try {
    $result = $apiInstance->stagesConsentList($consent_expire_in, $mode, $name, $ordering, $page, $page_size, $search, $stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesConsentList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **consent_expire_in** | **string**|  | [optional] |
| **mode** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedConsentStageList**](../Model/PaginatedConsentStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesConsentPartialUpdate()`

```php
stagesConsentPartialUpdate($stage_uuid, $patched_consent_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStage
```



ConsentStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Consent Stage.
$patched_consent_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedConsentStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedConsentStageRequest

try {
    $result = $apiInstance->stagesConsentPartialUpdate($stage_uuid, $patched_consent_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesConsentPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Consent Stage. | |
| **patched_consent_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedConsentStageRequest**](../Model/PatchedConsentStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStage**](../Model/ConsentStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesConsentRetrieve()`

```php
stagesConsentRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStage
```



ConsentStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Consent Stage.

try {
    $result = $apiInstance->stagesConsentRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesConsentRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Consent Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStage**](../Model/ConsentStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesConsentUpdate()`

```php
stagesConsentUpdate($stage_uuid, $consent_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStage
```



ConsentStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Consent Stage.
$consent_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStageRequest

try {
    $result = $apiInstance->stagesConsentUpdate($stage_uuid, $consent_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesConsentUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Consent Stage. | |
| **consent_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStageRequest**](../Model/ConsentStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentStage**](../Model/ConsentStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesConsentUsedByList()`

```php
stagesConsentUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Consent Stage.

try {
    $result = $apiInstance->stagesConsentUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesConsentUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Consent Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDenyCreate()`

```php
stagesDenyCreate($deny_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStage
```



DenyStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$deny_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStageRequest

try {
    $result = $apiInstance->stagesDenyCreate($deny_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDenyCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **deny_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStageRequest**](../Model/DenyStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStage**](../Model/DenyStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDenyDestroy()`

```php
stagesDenyDestroy($stage_uuid)
```



DenyStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Deny Stage.

try {
    $apiInstance->stagesDenyDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDenyDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Deny Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDenyList()`

```php
stagesDenyList($deny_message, $name, $ordering, $page, $page_size, $search, $stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDenyStageList
```



DenyStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$deny_message = 'deny_message_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string

try {
    $result = $apiInstance->stagesDenyList($deny_message, $name, $ordering, $page, $page_size, $search, $stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDenyList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **deny_message** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDenyStageList**](../Model/PaginatedDenyStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDenyPartialUpdate()`

```php
stagesDenyPartialUpdate($stage_uuid, $patched_deny_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStage
```



DenyStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Deny Stage.
$patched_deny_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDenyStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDenyStageRequest

try {
    $result = $apiInstance->stagesDenyPartialUpdate($stage_uuid, $patched_deny_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDenyPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Deny Stage. | |
| **patched_deny_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDenyStageRequest**](../Model/PatchedDenyStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStage**](../Model/DenyStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDenyRetrieve()`

```php
stagesDenyRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStage
```



DenyStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Deny Stage.

try {
    $result = $apiInstance->stagesDenyRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDenyRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Deny Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStage**](../Model/DenyStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDenyUpdate()`

```php
stagesDenyUpdate($stage_uuid, $deny_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStage
```



DenyStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Deny Stage.
$deny_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStageRequest

try {
    $result = $apiInstance->stagesDenyUpdate($stage_uuid, $deny_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDenyUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Deny Stage. | |
| **deny_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStageRequest**](../Model/DenyStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DenyStage**](../Model/DenyStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDenyUsedByList()`

```php
stagesDenyUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Deny Stage.

try {
    $result = $apiInstance->stagesDenyUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDenyUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Deny Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDummyCreate()`

```php
stagesDummyCreate($dummy_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStage
```



DummyStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$dummy_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStageRequest

try {
    $result = $apiInstance->stagesDummyCreate($dummy_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDummyCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **dummy_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStageRequest**](../Model/DummyStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStage**](../Model/DummyStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDummyDestroy()`

```php
stagesDummyDestroy($stage_uuid)
```



DummyStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Dummy Stage.

try {
    $apiInstance->stagesDummyDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDummyDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Dummy Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDummyList()`

```php
stagesDummyList($name, $ordering, $page, $page_size, $search, $stage_uuid, $throw_error): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDummyStageList
```



DummyStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string
$throw_error = True; // bool

try {
    $result = $apiInstance->stagesDummyList($name, $ordering, $page, $page_size, $search, $stage_uuid, $throw_error);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDummyList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |
| **throw_error** | **bool**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDummyStageList**](../Model/PaginatedDummyStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDummyPartialUpdate()`

```php
stagesDummyPartialUpdate($stage_uuid, $patched_dummy_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStage
```



DummyStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Dummy Stage.
$patched_dummy_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDummyStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDummyStageRequest

try {
    $result = $apiInstance->stagesDummyPartialUpdate($stage_uuid, $patched_dummy_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDummyPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Dummy Stage. | |
| **patched_dummy_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDummyStageRequest**](../Model/PatchedDummyStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStage**](../Model/DummyStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDummyRetrieve()`

```php
stagesDummyRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStage
```



DummyStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Dummy Stage.

try {
    $result = $apiInstance->stagesDummyRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDummyRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Dummy Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStage**](../Model/DummyStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDummyUpdate()`

```php
stagesDummyUpdate($stage_uuid, $dummy_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStage
```



DummyStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Dummy Stage.
$dummy_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStageRequest

try {
    $result = $apiInstance->stagesDummyUpdate($stage_uuid, $dummy_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDummyUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Dummy Stage. | |
| **dummy_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStageRequest**](../Model/DummyStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyStage**](../Model/DummyStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesDummyUsedByList()`

```php
stagesDummyUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Dummy Stage.

try {
    $result = $apiInstance->stagesDummyUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesDummyUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Dummy Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEmailCreate()`

```php
stagesEmailCreate($email_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStage
```



EmailStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$email_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStageRequest

try {
    $result = $apiInstance->stagesEmailCreate($email_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEmailCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **email_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStageRequest**](../Model/EmailStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStage**](../Model/EmailStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEmailDestroy()`

```php
stagesEmailDestroy($stage_uuid)
```



EmailStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Email Stage.

try {
    $apiInstance->stagesEmailDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEmailDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Email Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEmailList()`

```php
stagesEmailList($activate_user_on_success, $from_address, $host, $name, $ordering, $page, $page_size, $port, $search, $subject, $template, $timeout, $token_expiry, $use_global_settings, $use_ssl, $use_tls, $username): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEmailStageList
```



EmailStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$activate_user_on_success = True; // bool
$from_address = 'from_address_example'; // string
$host = 'host_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$port = 56; // int
$search = 'search_example'; // string | A search term.
$subject = 'subject_example'; // string
$template = 'template_example'; // string
$timeout = 56; // int
$token_expiry = 'token_expiry_example'; // string
$use_global_settings = True; // bool
$use_ssl = True; // bool
$use_tls = True; // bool
$username = 'username_example'; // string

try {
    $result = $apiInstance->stagesEmailList($activate_user_on_success, $from_address, $host, $name, $ordering, $page, $page_size, $port, $search, $subject, $template, $timeout, $token_expiry, $use_global_settings, $use_ssl, $use_tls, $username);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEmailList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **activate_user_on_success** | **bool**|  | [optional] |
| **from_address** | **string**|  | [optional] |
| **host** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **port** | **int**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **subject** | **string**|  | [optional] |
| **template** | **string**|  | [optional] |
| **timeout** | **int**|  | [optional] |
| **token_expiry** | **string**|  | [optional] |
| **use_global_settings** | **bool**|  | [optional] |
| **use_ssl** | **bool**|  | [optional] |
| **use_tls** | **bool**|  | [optional] |
| **username** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEmailStageList**](../Model/PaginatedEmailStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEmailPartialUpdate()`

```php
stagesEmailPartialUpdate($stage_uuid, $patched_email_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStage
```



EmailStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Email Stage.
$patched_email_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEmailStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEmailStageRequest

try {
    $result = $apiInstance->stagesEmailPartialUpdate($stage_uuid, $patched_email_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEmailPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Email Stage. | |
| **patched_email_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEmailStageRequest**](../Model/PatchedEmailStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStage**](../Model/EmailStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEmailRetrieve()`

```php
stagesEmailRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStage
```



EmailStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Email Stage.

try {
    $result = $apiInstance->stagesEmailRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEmailRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Email Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStage**](../Model/EmailStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEmailTemplatesList()`

```php
stagesEmailTemplatesList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TypeCreate[]
```



Get all available templates, including custom templates

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->stagesEmailTemplatesList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEmailTemplatesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TypeCreate[]**](../Model/TypeCreate.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEmailUpdate()`

```php
stagesEmailUpdate($stage_uuid, $email_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStage
```



EmailStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Email Stage.
$email_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStageRequest

try {
    $result = $apiInstance->stagesEmailUpdate($stage_uuid, $email_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEmailUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Email Stage. | |
| **email_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStageRequest**](../Model/EmailStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailStage**](../Model/EmailStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEmailUsedByList()`

```php
stagesEmailUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Email Stage.

try {
    $result = $apiInstance->stagesEmailUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEmailUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Email Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEndpointsCreate()`

```php
stagesEndpointsCreate($endpoint_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStage
```



EndpointStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$endpoint_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStageRequest

try {
    $result = $apiInstance->stagesEndpointsCreate($endpoint_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEndpointsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **endpoint_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStageRequest**](../Model/EndpointStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStage**](../Model/EndpointStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEndpointsDestroy()`

```php
stagesEndpointsDestroy($stage_uuid)
```



EndpointStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Endpoint Stage.

try {
    $apiInstance->stagesEndpointsDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEndpointsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Endpoint Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEndpointsList()`

```php
stagesEndpointsList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEndpointStageList
```



EndpointStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->stagesEndpointsList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEndpointsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEndpointStageList**](../Model/PaginatedEndpointStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEndpointsPartialUpdate()`

```php
stagesEndpointsPartialUpdate($stage_uuid, $patched_endpoint_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStage
```



EndpointStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Endpoint Stage.
$patched_endpoint_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEndpointStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEndpointStageRequest

try {
    $result = $apiInstance->stagesEndpointsPartialUpdate($stage_uuid, $patched_endpoint_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEndpointsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Endpoint Stage. | |
| **patched_endpoint_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEndpointStageRequest**](../Model/PatchedEndpointStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStage**](../Model/EndpointStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEndpointsRetrieve()`

```php
stagesEndpointsRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStage
```



EndpointStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Endpoint Stage.

try {
    $result = $apiInstance->stagesEndpointsRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEndpointsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Endpoint Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStage**](../Model/EndpointStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEndpointsUpdate()`

```php
stagesEndpointsUpdate($stage_uuid, $endpoint_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStage
```



EndpointStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Endpoint Stage.
$endpoint_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStageRequest

try {
    $result = $apiInstance->stagesEndpointsUpdate($stage_uuid, $endpoint_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEndpointsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Endpoint Stage. | |
| **endpoint_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStageRequest**](../Model/EndpointStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointStage**](../Model/EndpointStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesEndpointsUsedByList()`

```php
stagesEndpointsUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Endpoint Stage.

try {
    $result = $apiInstance->stagesEndpointsUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesEndpointsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Endpoint Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesIdentificationCreate()`

```php
stagesIdentificationCreate($identification_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStage
```



IdentificationStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$identification_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStageRequest

try {
    $result = $apiInstance->stagesIdentificationCreate($identification_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesIdentificationCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **identification_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStageRequest**](../Model/IdentificationStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStage**](../Model/IdentificationStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesIdentificationDestroy()`

```php
stagesIdentificationDestroy($stage_uuid)
```



IdentificationStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Identification Stage.

try {
    $apiInstance->stagesIdentificationDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesIdentificationDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Identification Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesIdentificationList()`

```php
stagesIdentificationList($captcha_stage, $case_insensitive_matching, $enrollment_flow, $name, $ordering, $page, $page_size, $password_stage, $passwordless_flow, $recovery_flow, $search, $show_matched_user, $show_source_labels, $webauthn_stage): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedIdentificationStageList
```



IdentificationStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$captcha_stage = 'captcha_stage_example'; // string
$case_insensitive_matching = True; // bool
$enrollment_flow = 'enrollment_flow_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$password_stage = 'password_stage_example'; // string
$passwordless_flow = 'passwordless_flow_example'; // string
$recovery_flow = 'recovery_flow_example'; // string
$search = 'search_example'; // string | A search term.
$show_matched_user = True; // bool
$show_source_labels = True; // bool
$webauthn_stage = 'webauthn_stage_example'; // string

try {
    $result = $apiInstance->stagesIdentificationList($captcha_stage, $case_insensitive_matching, $enrollment_flow, $name, $ordering, $page, $page_size, $password_stage, $passwordless_flow, $recovery_flow, $search, $show_matched_user, $show_source_labels, $webauthn_stage);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesIdentificationList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **captcha_stage** | **string**|  | [optional] |
| **case_insensitive_matching** | **bool**|  | [optional] |
| **enrollment_flow** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **password_stage** | **string**|  | [optional] |
| **passwordless_flow** | **string**|  | [optional] |
| **recovery_flow** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **show_matched_user** | **bool**|  | [optional] |
| **show_source_labels** | **bool**|  | [optional] |
| **webauthn_stage** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedIdentificationStageList**](../Model/PaginatedIdentificationStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesIdentificationPartialUpdate()`

```php
stagesIdentificationPartialUpdate($stage_uuid, $patched_identification_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStage
```



IdentificationStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Identification Stage.
$patched_identification_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedIdentificationStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedIdentificationStageRequest

try {
    $result = $apiInstance->stagesIdentificationPartialUpdate($stage_uuid, $patched_identification_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesIdentificationPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Identification Stage. | |
| **patched_identification_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedIdentificationStageRequest**](../Model/PatchedIdentificationStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStage**](../Model/IdentificationStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesIdentificationRetrieve()`

```php
stagesIdentificationRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStage
```



IdentificationStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Identification Stage.

try {
    $result = $apiInstance->stagesIdentificationRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesIdentificationRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Identification Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStage**](../Model/IdentificationStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesIdentificationUpdate()`

```php
stagesIdentificationUpdate($stage_uuid, $identification_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStage
```



IdentificationStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Identification Stage.
$identification_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStageRequest

try {
    $result = $apiInstance->stagesIdentificationUpdate($stage_uuid, $identification_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesIdentificationUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Identification Stage. | |
| **identification_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStageRequest**](../Model/IdentificationStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\IdentificationStage**](../Model/IdentificationStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesIdentificationUsedByList()`

```php
stagesIdentificationUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Identification Stage.

try {
    $result = $apiInstance->stagesIdentificationUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesIdentificationUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Identification Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationInvitationsCreate()`

```php
stagesInvitationInvitationsCreate($invitation_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Invitation
```



Invitation Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$invitation_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationRequest

try {
    $result = $apiInstance->stagesInvitationInvitationsCreate($invitation_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationInvitationsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **invitation_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationRequest**](../Model/InvitationRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Invitation**](../Model/Invitation.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationInvitationsDestroy()`

```php
stagesInvitationInvitationsDestroy($invite_uuid)
```



Invitation Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$invite_uuid = 'invite_uuid_example'; // string | A UUID string identifying this Invitation.

try {
    $apiInstance->stagesInvitationInvitationsDestroy($invite_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationInvitationsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **invite_uuid** | **string**| A UUID string identifying this Invitation. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationInvitationsList()`

```php
stagesInvitationInvitationsList($created_by__username, $expires, $flow__slug, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedInvitationList
```



Invitation Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$created_by__username = 'created_by__username_example'; // string
$expires = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$flow__slug = 'flow__slug_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->stagesInvitationInvitationsList($created_by__username, $expires, $flow__slug, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationInvitationsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **created_by__username** | **string**|  | [optional] |
| **expires** | **\DateTime**|  | [optional] |
| **flow__slug** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedInvitationList**](../Model/PaginatedInvitationList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationInvitationsPartialUpdate()`

```php
stagesInvitationInvitationsPartialUpdate($invite_uuid, $patched_invitation_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Invitation
```



Invitation Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$invite_uuid = 'invite_uuid_example'; // string | A UUID string identifying this Invitation.
$patched_invitation_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedInvitationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedInvitationRequest

try {
    $result = $apiInstance->stagesInvitationInvitationsPartialUpdate($invite_uuid, $patched_invitation_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationInvitationsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **invite_uuid** | **string**| A UUID string identifying this Invitation. | |
| **patched_invitation_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedInvitationRequest**](../Model/PatchedInvitationRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Invitation**](../Model/Invitation.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationInvitationsRetrieve()`

```php
stagesInvitationInvitationsRetrieve($invite_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Invitation
```



Invitation Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$invite_uuid = 'invite_uuid_example'; // string | A UUID string identifying this Invitation.

try {
    $result = $apiInstance->stagesInvitationInvitationsRetrieve($invite_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationInvitationsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **invite_uuid** | **string**| A UUID string identifying this Invitation. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Invitation**](../Model/Invitation.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationInvitationsUpdate()`

```php
stagesInvitationInvitationsUpdate($invite_uuid, $invitation_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Invitation
```



Invitation Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$invite_uuid = 'invite_uuid_example'; // string | A UUID string identifying this Invitation.
$invitation_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationRequest

try {
    $result = $apiInstance->stagesInvitationInvitationsUpdate($invite_uuid, $invitation_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationInvitationsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **invite_uuid** | **string**| A UUID string identifying this Invitation. | |
| **invitation_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationRequest**](../Model/InvitationRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Invitation**](../Model/Invitation.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationInvitationsUsedByList()`

```php
stagesInvitationInvitationsUsedByList($invite_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$invite_uuid = 'invite_uuid_example'; // string | A UUID string identifying this Invitation.

try {
    $result = $apiInstance->stagesInvitationInvitationsUsedByList($invite_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationInvitationsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **invite_uuid** | **string**| A UUID string identifying this Invitation. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationStagesCreate()`

```php
stagesInvitationStagesCreate($invitation_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStage
```



InvitationStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$invitation_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStageRequest

try {
    $result = $apiInstance->stagesInvitationStagesCreate($invitation_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationStagesCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **invitation_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStageRequest**](../Model/InvitationStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStage**](../Model/InvitationStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationStagesDestroy()`

```php
stagesInvitationStagesDestroy($stage_uuid)
```



InvitationStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Invitation Stage.

try {
    $apiInstance->stagesInvitationStagesDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationStagesDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Invitation Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationStagesList()`

```php
stagesInvitationStagesList($continue_flow_without_invitation, $name, $no_flows, $ordering, $page, $page_size, $search, $stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedInvitationStageList
```



InvitationStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$continue_flow_without_invitation = True; // bool
$name = 'name_example'; // string
$no_flows = True; // bool
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string

try {
    $result = $apiInstance->stagesInvitationStagesList($continue_flow_without_invitation, $name, $no_flows, $ordering, $page, $page_size, $search, $stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationStagesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **continue_flow_without_invitation** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **no_flows** | **bool**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedInvitationStageList**](../Model/PaginatedInvitationStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationStagesPartialUpdate()`

```php
stagesInvitationStagesPartialUpdate($stage_uuid, $patched_invitation_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStage
```



InvitationStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Invitation Stage.
$patched_invitation_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedInvitationStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedInvitationStageRequest

try {
    $result = $apiInstance->stagesInvitationStagesPartialUpdate($stage_uuid, $patched_invitation_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationStagesPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Invitation Stage. | |
| **patched_invitation_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedInvitationStageRequest**](../Model/PatchedInvitationStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStage**](../Model/InvitationStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationStagesRetrieve()`

```php
stagesInvitationStagesRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStage
```



InvitationStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Invitation Stage.

try {
    $result = $apiInstance->stagesInvitationStagesRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationStagesRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Invitation Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStage**](../Model/InvitationStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationStagesUpdate()`

```php
stagesInvitationStagesUpdate($stage_uuid, $invitation_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStage
```



InvitationStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Invitation Stage.
$invitation_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStageRequest

try {
    $result = $apiInstance->stagesInvitationStagesUpdate($stage_uuid, $invitation_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationStagesUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Invitation Stage. | |
| **invitation_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStageRequest**](../Model/InvitationStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvitationStage**](../Model/InvitationStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesInvitationStagesUsedByList()`

```php
stagesInvitationStagesUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Invitation Stage.

try {
    $result = $apiInstance->stagesInvitationStagesUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesInvitationStagesUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Invitation Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesMtlsCreate()`

```php
stagesMtlsCreate($mutual_tls_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStage
```



MutualTLSStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$mutual_tls_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStageRequest

try {
    $result = $apiInstance->stagesMtlsCreate($mutual_tls_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesMtlsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **mutual_tls_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStageRequest**](../Model/MutualTLSStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStage**](../Model/MutualTLSStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesMtlsDestroy()`

```php
stagesMtlsDestroy($stage_uuid)
```



MutualTLSStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Mutual TLS Stage.

try {
    $apiInstance->stagesMtlsDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesMtlsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Mutual TLS Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesMtlsList()`

```php
stagesMtlsList($cert_attribute, $certificate_authorities, $mode, $name, $ordering, $page, $page_size, $search, $stage_uuid, $user_attribute): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedMutualTLSStageList
```



MutualTLSStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$cert_attribute = 'cert_attribute_example'; // string
$certificate_authorities = array('certificate_authorities_example'); // string[]
$mode = 'mode_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string
$user_attribute = 'user_attribute_example'; // string

try {
    $result = $apiInstance->stagesMtlsList($cert_attribute, $certificate_authorities, $mode, $name, $ordering, $page, $page_size, $search, $stage_uuid, $user_attribute);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesMtlsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **cert_attribute** | **string**|  | [optional] |
| **certificate_authorities** | [**string[]**](../Model/string.md)|  | [optional] |
| **mode** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |
| **user_attribute** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedMutualTLSStageList**](../Model/PaginatedMutualTLSStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesMtlsPartialUpdate()`

```php
stagesMtlsPartialUpdate($stage_uuid, $patched_mutual_tls_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStage
```



MutualTLSStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Mutual TLS Stage.
$patched_mutual_tls_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedMutualTLSStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedMutualTLSStageRequest

try {
    $result = $apiInstance->stagesMtlsPartialUpdate($stage_uuid, $patched_mutual_tls_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesMtlsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Mutual TLS Stage. | |
| **patched_mutual_tls_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedMutualTLSStageRequest**](../Model/PatchedMutualTLSStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStage**](../Model/MutualTLSStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesMtlsRetrieve()`

```php
stagesMtlsRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStage
```



MutualTLSStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Mutual TLS Stage.

try {
    $result = $apiInstance->stagesMtlsRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesMtlsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Mutual TLS Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStage**](../Model/MutualTLSStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesMtlsUpdate()`

```php
stagesMtlsUpdate($stage_uuid, $mutual_tls_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStage
```



MutualTLSStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Mutual TLS Stage.
$mutual_tls_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStageRequest

try {
    $result = $apiInstance->stagesMtlsUpdate($stage_uuid, $mutual_tls_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesMtlsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Mutual TLS Stage. | |
| **mutual_tls_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStageRequest**](../Model/MutualTLSStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MutualTLSStage**](../Model/MutualTLSStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesMtlsUsedByList()`

```php
stagesMtlsUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Mutual TLS Stage.

try {
    $result = $apiInstance->stagesMtlsUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesMtlsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Mutual TLS Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPasswordCreate()`

```php
stagesPasswordCreate($password_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStage
```



PasswordStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$password_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStageRequest

try {
    $result = $apiInstance->stagesPasswordCreate($password_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPasswordCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **password_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStageRequest**](../Model/PasswordStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStage**](../Model/PasswordStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPasswordDestroy()`

```php
stagesPasswordDestroy($stage_uuid)
```



PasswordStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Password Stage.

try {
    $apiInstance->stagesPasswordDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPasswordDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Password Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPasswordList()`

```php
stagesPasswordList($allow_show_password, $configure_flow, $failed_attempts_before_cancel, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPasswordStageList
```



PasswordStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$allow_show_password = True; // bool
$configure_flow = 'configure_flow_example'; // string
$failed_attempts_before_cancel = 56; // int
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->stagesPasswordList($allow_show_password, $configure_flow, $failed_attempts_before_cancel, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPasswordList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **allow_show_password** | **bool**|  | [optional] |
| **configure_flow** | **string**|  | [optional] |
| **failed_attempts_before_cancel** | **int**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPasswordStageList**](../Model/PaginatedPasswordStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPasswordPartialUpdate()`

```php
stagesPasswordPartialUpdate($stage_uuid, $patched_password_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStage
```



PasswordStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Password Stage.
$patched_password_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPasswordStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPasswordStageRequest

try {
    $result = $apiInstance->stagesPasswordPartialUpdate($stage_uuid, $patched_password_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPasswordPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Password Stage. | |
| **patched_password_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPasswordStageRequest**](../Model/PatchedPasswordStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStage**](../Model/PasswordStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPasswordRetrieve()`

```php
stagesPasswordRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStage
```



PasswordStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Password Stage.

try {
    $result = $apiInstance->stagesPasswordRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPasswordRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Password Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStage**](../Model/PasswordStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPasswordUpdate()`

```php
stagesPasswordUpdate($stage_uuid, $password_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStage
```



PasswordStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Password Stage.
$password_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStageRequest

try {
    $result = $apiInstance->stagesPasswordUpdate($stage_uuid, $password_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPasswordUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Password Stage. | |
| **password_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStageRequest**](../Model/PasswordStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordStage**](../Model/PasswordStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPasswordUsedByList()`

```php
stagesPasswordUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Password Stage.

try {
    $result = $apiInstance->stagesPasswordUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPasswordUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Password Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptPromptsCreate()`

```php
stagesPromptPromptsCreate($prompt_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Prompt
```



Prompt Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$prompt_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptRequest

try {
    $result = $apiInstance->stagesPromptPromptsCreate($prompt_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptPromptsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **prompt_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptRequest**](../Model/PromptRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Prompt**](../Model/Prompt.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptPromptsDestroy()`

```php
stagesPromptPromptsDestroy($prompt_uuid)
```



Prompt Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$prompt_uuid = 'prompt_uuid_example'; // string | A UUID string identifying this Prompt.

try {
    $apiInstance->stagesPromptPromptsDestroy($prompt_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptPromptsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **prompt_uuid** | **string**| A UUID string identifying this Prompt. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptPromptsList()`

```php
stagesPromptPromptsList($field_key, $label, $name, $ordering, $page, $page_size, $placeholder, $search, $type): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPromptList
```



Prompt Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$field_key = 'field_key_example'; // string
$label = 'label_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$placeholder = 'placeholder_example'; // string
$search = 'search_example'; // string | A search term.
$type = 'type_example'; // string

try {
    $result = $apiInstance->stagesPromptPromptsList($field_key, $label, $name, $ordering, $page, $page_size, $placeholder, $search, $type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptPromptsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **field_key** | **string**|  | [optional] |
| **label** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **placeholder** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **type** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPromptList**](../Model/PaginatedPromptList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptPromptsPartialUpdate()`

```php
stagesPromptPromptsPartialUpdate($prompt_uuid, $patched_prompt_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Prompt
```



Prompt Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$prompt_uuid = 'prompt_uuid_example'; // string | A UUID string identifying this Prompt.
$patched_prompt_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPromptRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPromptRequest

try {
    $result = $apiInstance->stagesPromptPromptsPartialUpdate($prompt_uuid, $patched_prompt_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptPromptsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **prompt_uuid** | **string**| A UUID string identifying this Prompt. | |
| **patched_prompt_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPromptRequest**](../Model/PatchedPromptRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Prompt**](../Model/Prompt.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptPromptsPreviewCreate()`

```php
stagesPromptPromptsPreviewCreate($prompt_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptChallenge
```



Preview a prompt as a challenge, just like a flow would receive

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$prompt_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptRequest

try {
    $result = $apiInstance->stagesPromptPromptsPreviewCreate($prompt_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptPromptsPreviewCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **prompt_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptRequest**](../Model/PromptRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptChallenge**](../Model/PromptChallenge.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptPromptsRetrieve()`

```php
stagesPromptPromptsRetrieve($prompt_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Prompt
```



Prompt Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$prompt_uuid = 'prompt_uuid_example'; // string | A UUID string identifying this Prompt.

try {
    $result = $apiInstance->stagesPromptPromptsRetrieve($prompt_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptPromptsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **prompt_uuid** | **string**| A UUID string identifying this Prompt. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Prompt**](../Model/Prompt.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptPromptsUpdate()`

```php
stagesPromptPromptsUpdate($prompt_uuid, $prompt_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Prompt
```



Prompt Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$prompt_uuid = 'prompt_uuid_example'; // string | A UUID string identifying this Prompt.
$prompt_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptRequest

try {
    $result = $apiInstance->stagesPromptPromptsUpdate($prompt_uuid, $prompt_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptPromptsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **prompt_uuid** | **string**| A UUID string identifying this Prompt. | |
| **prompt_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptRequest**](../Model/PromptRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Prompt**](../Model/Prompt.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptPromptsUsedByList()`

```php
stagesPromptPromptsUsedByList($prompt_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$prompt_uuid = 'prompt_uuid_example'; // string | A UUID string identifying this Prompt.

try {
    $result = $apiInstance->stagesPromptPromptsUsedByList($prompt_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptPromptsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **prompt_uuid** | **string**| A UUID string identifying this Prompt. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptStagesCreate()`

```php
stagesPromptStagesCreate($prompt_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStage
```



PromptStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$prompt_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStageRequest

try {
    $result = $apiInstance->stagesPromptStagesCreate($prompt_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptStagesCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **prompt_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStageRequest**](../Model/PromptStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStage**](../Model/PromptStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptStagesDestroy()`

```php
stagesPromptStagesDestroy($stage_uuid)
```



PromptStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Prompt Stage.

try {
    $apiInstance->stagesPromptStagesDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptStagesDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Prompt Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptStagesList()`

```php
stagesPromptStagesList($fields, $name, $ordering, $page, $page_size, $search, $stage_uuid, $validation_policies): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPromptStageList
```



PromptStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$fields = array('fields_example'); // string[]
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string
$validation_policies = array('validation_policies_example'); // string[]

try {
    $result = $apiInstance->stagesPromptStagesList($fields, $name, $ordering, $page, $page_size, $search, $stage_uuid, $validation_policies);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptStagesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **fields** | [**string[]**](../Model/string.md)|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |
| **validation_policies** | [**string[]**](../Model/string.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPromptStageList**](../Model/PaginatedPromptStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptStagesPartialUpdate()`

```php
stagesPromptStagesPartialUpdate($stage_uuid, $patched_prompt_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStage
```



PromptStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Prompt Stage.
$patched_prompt_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPromptStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPromptStageRequest

try {
    $result = $apiInstance->stagesPromptStagesPartialUpdate($stage_uuid, $patched_prompt_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptStagesPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Prompt Stage. | |
| **patched_prompt_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPromptStageRequest**](../Model/PatchedPromptStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStage**](../Model/PromptStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptStagesRetrieve()`

```php
stagesPromptStagesRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStage
```



PromptStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Prompt Stage.

try {
    $result = $apiInstance->stagesPromptStagesRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptStagesRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Prompt Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStage**](../Model/PromptStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptStagesUpdate()`

```php
stagesPromptStagesUpdate($stage_uuid, $prompt_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStage
```



PromptStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Prompt Stage.
$prompt_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStageRequest

try {
    $result = $apiInstance->stagesPromptStagesUpdate($stage_uuid, $prompt_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptStagesUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Prompt Stage. | |
| **prompt_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStageRequest**](../Model/PromptStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptStage**](../Model/PromptStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesPromptStagesUsedByList()`

```php
stagesPromptStagesUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Prompt Stage.

try {
    $result = $apiInstance->stagesPromptStagesUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesPromptStagesUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Prompt Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesRedirectCreate()`

```php
stagesRedirectCreate($redirect_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStage
```



RedirectStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$redirect_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStageRequest

try {
    $result = $apiInstance->stagesRedirectCreate($redirect_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesRedirectCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **redirect_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStageRequest**](../Model/RedirectStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStage**](../Model/RedirectStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesRedirectDestroy()`

```php
stagesRedirectDestroy($stage_uuid)
```



RedirectStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Redirect Stage.

try {
    $apiInstance->stagesRedirectDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesRedirectDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Redirect Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesRedirectList()`

```php
stagesRedirectList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRedirectStageList
```



RedirectStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->stagesRedirectList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesRedirectList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRedirectStageList**](../Model/PaginatedRedirectStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesRedirectPartialUpdate()`

```php
stagesRedirectPartialUpdate($stage_uuid, $patched_redirect_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStage
```



RedirectStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Redirect Stage.
$patched_redirect_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRedirectStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRedirectStageRequest

try {
    $result = $apiInstance->stagesRedirectPartialUpdate($stage_uuid, $patched_redirect_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesRedirectPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Redirect Stage. | |
| **patched_redirect_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRedirectStageRequest**](../Model/PatchedRedirectStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStage**](../Model/RedirectStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesRedirectRetrieve()`

```php
stagesRedirectRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStage
```



RedirectStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Redirect Stage.

try {
    $result = $apiInstance->stagesRedirectRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesRedirectRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Redirect Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStage**](../Model/RedirectStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesRedirectUpdate()`

```php
stagesRedirectUpdate($stage_uuid, $redirect_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStage
```



RedirectStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Redirect Stage.
$redirect_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStageRequest

try {
    $result = $apiInstance->stagesRedirectUpdate($stage_uuid, $redirect_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesRedirectUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Redirect Stage. | |
| **redirect_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStageRequest**](../Model/RedirectStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RedirectStage**](../Model/RedirectStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesRedirectUsedByList()`

```php
stagesRedirectUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Redirect Stage.

try {
    $result = $apiInstance->stagesRedirectUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesRedirectUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Redirect Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesSourceCreate()`

```php
stagesSourceCreate($source_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStage
```



SourceStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$source_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStageRequest

try {
    $result = $apiInstance->stagesSourceCreate($source_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesSourceCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **source_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStageRequest**](../Model/SourceStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStage**](../Model/SourceStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesSourceDestroy()`

```php
stagesSourceDestroy($stage_uuid)
```



SourceStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Source Stage.

try {
    $apiInstance->stagesSourceDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesSourceDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Source Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesSourceList()`

```php
stagesSourceList($name, $ordering, $page, $page_size, $resume_timeout, $search, $source, $stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSourceStageList
```



SourceStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$resume_timeout = 'resume_timeout_example'; // string
$search = 'search_example'; // string | A search term.
$source = 'source_example'; // string
$stage_uuid = 'stage_uuid_example'; // string

try {
    $result = $apiInstance->stagesSourceList($name, $ordering, $page, $page_size, $resume_timeout, $search, $source, $stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesSourceList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **resume_timeout** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **source** | **string**|  | [optional] |
| **stage_uuid** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSourceStageList**](../Model/PaginatedSourceStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesSourcePartialUpdate()`

```php
stagesSourcePartialUpdate($stage_uuid, $patched_source_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStage
```



SourceStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Source Stage.
$patched_source_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSourceStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSourceStageRequest

try {
    $result = $apiInstance->stagesSourcePartialUpdate($stage_uuid, $patched_source_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesSourcePartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Source Stage. | |
| **patched_source_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSourceStageRequest**](../Model/PatchedSourceStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStage**](../Model/SourceStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesSourceRetrieve()`

```php
stagesSourceRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStage
```



SourceStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Source Stage.

try {
    $result = $apiInstance->stagesSourceRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesSourceRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Source Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStage**](../Model/SourceStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesSourceUpdate()`

```php
stagesSourceUpdate($stage_uuid, $source_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStage
```



SourceStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Source Stage.
$source_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStageRequest

try {
    $result = $apiInstance->stagesSourceUpdate($stage_uuid, $source_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesSourceUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Source Stage. | |
| **source_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStageRequest**](../Model/SourceStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SourceStage**](../Model/SourceStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesSourceUsedByList()`

```php
stagesSourceUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this Source Stage.

try {
    $result = $apiInstance->stagesSourceUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesSourceUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this Source Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserDeleteCreate()`

```php
stagesUserDeleteCreate($user_delete_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStage
```



UserDeleteStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$user_delete_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStageRequest

try {
    $result = $apiInstance->stagesUserDeleteCreate($user_delete_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserDeleteCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **user_delete_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStageRequest**](../Model/UserDeleteStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStage**](../Model/UserDeleteStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserDeleteDestroy()`

```php
stagesUserDeleteDestroy($stage_uuid)
```



UserDeleteStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Delete Stage.

try {
    $apiInstance->stagesUserDeleteDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserDeleteDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Delete Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserDeleteList()`

```php
stagesUserDeleteList($name, $ordering, $page, $page_size, $search, $stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUserDeleteStageList
```



UserDeleteStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string

try {
    $result = $apiInstance->stagesUserDeleteList($name, $ordering, $page, $page_size, $search, $stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserDeleteList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUserDeleteStageList**](../Model/PaginatedUserDeleteStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserDeletePartialUpdate()`

```php
stagesUserDeletePartialUpdate($stage_uuid, $patched_user_delete_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStage
```



UserDeleteStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Delete Stage.
$patched_user_delete_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserDeleteStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserDeleteStageRequest

try {
    $result = $apiInstance->stagesUserDeletePartialUpdate($stage_uuid, $patched_user_delete_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserDeletePartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Delete Stage. | |
| **patched_user_delete_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserDeleteStageRequest**](../Model/PatchedUserDeleteStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStage**](../Model/UserDeleteStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserDeleteRetrieve()`

```php
stagesUserDeleteRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStage
```



UserDeleteStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Delete Stage.

try {
    $result = $apiInstance->stagesUserDeleteRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserDeleteRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Delete Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStage**](../Model/UserDeleteStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserDeleteUpdate()`

```php
stagesUserDeleteUpdate($stage_uuid, $user_delete_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStage
```



UserDeleteStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Delete Stage.
$user_delete_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStageRequest

try {
    $result = $apiInstance->stagesUserDeleteUpdate($stage_uuid, $user_delete_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserDeleteUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Delete Stage. | |
| **user_delete_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStageRequest**](../Model/UserDeleteStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserDeleteStage**](../Model/UserDeleteStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserDeleteUsedByList()`

```php
stagesUserDeleteUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Delete Stage.

try {
    $result = $apiInstance->stagesUserDeleteUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserDeleteUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Delete Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLoginCreate()`

```php
stagesUserLoginCreate($user_login_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStage
```



UserLoginStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$user_login_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStageRequest

try {
    $result = $apiInstance->stagesUserLoginCreate($user_login_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLoginCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **user_login_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStageRequest**](../Model/UserLoginStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStage**](../Model/UserLoginStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLoginDestroy()`

```php
stagesUserLoginDestroy($stage_uuid)
```



UserLoginStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Login Stage.

try {
    $apiInstance->stagesUserLoginDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLoginDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Login Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLoginList()`

```php
stagesUserLoginList($geoip_binding, $name, $network_binding, $ordering, $page, $page_size, $remember_device, $remember_me_offset, $search, $session_duration, $stage_uuid, $terminate_other_sessions): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUserLoginStageList
```



UserLoginStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$geoip_binding = 'geoip_binding_example'; // string | Bind sessions created by this stage to the configured GeoIP location
$name = 'name_example'; // string
$network_binding = 'network_binding_example'; // string | Bind sessions created by this stage to the configured network
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$remember_device = 'remember_device_example'; // string
$remember_me_offset = 'remember_me_offset_example'; // string
$search = 'search_example'; // string | A search term.
$session_duration = 'session_duration_example'; // string
$stage_uuid = 'stage_uuid_example'; // string
$terminate_other_sessions = True; // bool

try {
    $result = $apiInstance->stagesUserLoginList($geoip_binding, $name, $network_binding, $ordering, $page, $page_size, $remember_device, $remember_me_offset, $search, $session_duration, $stage_uuid, $terminate_other_sessions);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLoginList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **geoip_binding** | **string**| Bind sessions created by this stage to the configured GeoIP location | [optional] |
| **name** | **string**|  | [optional] |
| **network_binding** | **string**| Bind sessions created by this stage to the configured network | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **remember_device** | **string**|  | [optional] |
| **remember_me_offset** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **session_duration** | **string**|  | [optional] |
| **stage_uuid** | **string**|  | [optional] |
| **terminate_other_sessions** | **bool**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUserLoginStageList**](../Model/PaginatedUserLoginStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLoginPartialUpdate()`

```php
stagesUserLoginPartialUpdate($stage_uuid, $patched_user_login_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStage
```



UserLoginStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Login Stage.
$patched_user_login_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserLoginStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserLoginStageRequest

try {
    $result = $apiInstance->stagesUserLoginPartialUpdate($stage_uuid, $patched_user_login_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLoginPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Login Stage. | |
| **patched_user_login_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserLoginStageRequest**](../Model/PatchedUserLoginStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStage**](../Model/UserLoginStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLoginRetrieve()`

```php
stagesUserLoginRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStage
```



UserLoginStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Login Stage.

try {
    $result = $apiInstance->stagesUserLoginRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLoginRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Login Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStage**](../Model/UserLoginStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLoginUpdate()`

```php
stagesUserLoginUpdate($stage_uuid, $user_login_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStage
```



UserLoginStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Login Stage.
$user_login_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStageRequest

try {
    $result = $apiInstance->stagesUserLoginUpdate($stage_uuid, $user_login_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLoginUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Login Stage. | |
| **user_login_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStageRequest**](../Model/UserLoginStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLoginStage**](../Model/UserLoginStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLoginUsedByList()`

```php
stagesUserLoginUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Login Stage.

try {
    $result = $apiInstance->stagesUserLoginUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLoginUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Login Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLogoutCreate()`

```php
stagesUserLogoutCreate($user_logout_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStage
```



UserLogoutStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$user_logout_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStageRequest

try {
    $result = $apiInstance->stagesUserLogoutCreate($user_logout_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLogoutCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **user_logout_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStageRequest**](../Model/UserLogoutStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStage**](../Model/UserLogoutStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLogoutDestroy()`

```php
stagesUserLogoutDestroy($stage_uuid)
```



UserLogoutStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Logout Stage.

try {
    $apiInstance->stagesUserLogoutDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLogoutDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Logout Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLogoutList()`

```php
stagesUserLogoutList($name, $ordering, $page, $page_size, $search, $stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUserLogoutStageList
```



UserLogoutStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string

try {
    $result = $apiInstance->stagesUserLogoutList($name, $ordering, $page, $page_size, $search, $stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLogoutList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUserLogoutStageList**](../Model/PaginatedUserLogoutStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLogoutPartialUpdate()`

```php
stagesUserLogoutPartialUpdate($stage_uuid, $patched_user_logout_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStage
```



UserLogoutStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Logout Stage.
$patched_user_logout_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserLogoutStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserLogoutStageRequest

try {
    $result = $apiInstance->stagesUserLogoutPartialUpdate($stage_uuid, $patched_user_logout_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLogoutPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Logout Stage. | |
| **patched_user_logout_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserLogoutStageRequest**](../Model/PatchedUserLogoutStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStage**](../Model/UserLogoutStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLogoutRetrieve()`

```php
stagesUserLogoutRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStage
```



UserLogoutStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Logout Stage.

try {
    $result = $apiInstance->stagesUserLogoutRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLogoutRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Logout Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStage**](../Model/UserLogoutStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLogoutUpdate()`

```php
stagesUserLogoutUpdate($stage_uuid, $user_logout_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStage
```



UserLogoutStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Logout Stage.
$user_logout_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStageRequest

try {
    $result = $apiInstance->stagesUserLogoutUpdate($stage_uuid, $user_logout_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLogoutUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Logout Stage. | |
| **user_logout_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStageRequest**](../Model/UserLogoutStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserLogoutStage**](../Model/UserLogoutStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserLogoutUsedByList()`

```php
stagesUserLogoutUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Logout Stage.

try {
    $result = $apiInstance->stagesUserLogoutUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserLogoutUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Logout Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserWriteCreate()`

```php
stagesUserWriteCreate($user_write_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStage
```



UserWriteStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$user_write_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStageRequest

try {
    $result = $apiInstance->stagesUserWriteCreate($user_write_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserWriteCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **user_write_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStageRequest**](../Model/UserWriteStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStage**](../Model/UserWriteStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserWriteDestroy()`

```php
stagesUserWriteDestroy($stage_uuid)
```



UserWriteStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Write Stage.

try {
    $apiInstance->stagesUserWriteDestroy($stage_uuid);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserWriteDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Write Stage. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserWriteList()`

```php
stagesUserWriteList($create_users_as_inactive, $create_users_group, $name, $ordering, $page, $page_size, $search, $stage_uuid, $user_creation_mode, $user_path_template, $user_type): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUserWriteStageList
```



UserWriteStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$create_users_as_inactive = True; // bool
$create_users_group = 'create_users_group_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$stage_uuid = 'stage_uuid_example'; // string
$user_creation_mode = 'user_creation_mode_example'; // string
$user_path_template = 'user_path_template_example'; // string
$user_type = 'user_type_example'; // string

try {
    $result = $apiInstance->stagesUserWriteList($create_users_as_inactive, $create_users_group, $name, $ordering, $page, $page_size, $search, $stage_uuid, $user_creation_mode, $user_path_template, $user_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserWriteList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **create_users_as_inactive** | **bool**|  | [optional] |
| **create_users_group** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage_uuid** | **string**|  | [optional] |
| **user_creation_mode** | **string**|  | [optional] |
| **user_path_template** | **string**|  | [optional] |
| **user_type** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUserWriteStageList**](../Model/PaginatedUserWriteStageList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserWritePartialUpdate()`

```php
stagesUserWritePartialUpdate($stage_uuid, $patched_user_write_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStage
```



UserWriteStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Write Stage.
$patched_user_write_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserWriteStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserWriteStageRequest

try {
    $result = $apiInstance->stagesUserWritePartialUpdate($stage_uuid, $patched_user_write_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserWritePartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Write Stage. | |
| **patched_user_write_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserWriteStageRequest**](../Model/PatchedUserWriteStageRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStage**](../Model/UserWriteStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserWriteRetrieve()`

```php
stagesUserWriteRetrieve($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStage
```



UserWriteStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Write Stage.

try {
    $result = $apiInstance->stagesUserWriteRetrieve($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserWriteRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Write Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStage**](../Model/UserWriteStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserWriteUpdate()`

```php
stagesUserWriteUpdate($stage_uuid, $user_write_stage_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStage
```



UserWriteStage Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Write Stage.
$user_write_stage_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStageRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStageRequest

try {
    $result = $apiInstance->stagesUserWriteUpdate($stage_uuid, $user_write_stage_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserWriteUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Write Stage. | |
| **user_write_stage_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStageRequest**](../Model/UserWriteStageRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserWriteStage**](../Model/UserWriteStage.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `stagesUserWriteUsedByList()`

```php
stagesUserWriteUsedByList($stage_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\StagesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$stage_uuid = 'stage_uuid_example'; // string | A UUID string identifying this User Write Stage.

try {
    $result = $apiInstance->stagesUserWriteUsedByList($stage_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StagesApi->stagesUserWriteUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **stage_uuid** | **string**| A UUID string identifying this User Write Stage. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)
