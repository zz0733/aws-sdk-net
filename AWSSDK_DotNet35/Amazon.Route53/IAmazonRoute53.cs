/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;

using Amazon.Route53;
using Amazon.Route53.Model;

namespace Amazon.Route53
{
    /// <summary>
    /// Interface for accessing AmazonRoute53.
    ///  
    ///  
    /// </summary>
    public interface IAmazonRoute53 : IDisposable
    {


        #region ChangeResourceRecordSets

        /// <summary>
        /// <para>Use this action to create or change your authoritative DNS information. To use this action, send a <c>POST</c> request to the
        /// <c>2012-12-12/hostedzone/hosted Zone ID/rrset</c> resource. The request body must include an XML document with a
        /// <c>ChangeResourceRecordSetsRequest</c> element.</para> <para>Changes are a list of change items and are considered transactional. For more
        /// information on transactional changes, also known as change batches, see <a
        /// href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/RRSchanges.html#RRSchanges_API" >Creating, Changing, and Deleting Resource
        /// Record Sets Using the Route 53 API</a> in the <i>Amazon Route 53 Developer Guide</i> .</para> <para><b>IMPORTANT:</b>Due to the nature of
        /// transactional changes, you cannot delete the same resource record set more than once in a single change batch. If you attempt to delete the
        /// same change batch more than once, Route 53 returns an InvalidChangeBatch error.</para> <para>In response to a
        /// <c>ChangeResourceRecordSets</c> request, your DNS data is changed on all Route 53 DNS servers. Initially, the status of a change is
        /// <c>PENDING</c> . This means the change has not yet propagated to all the authoritative Route 53 DNS servers. When the change is propagated
        /// to all hosts, the change returns a status of <c>INSYNC</c> .</para> <para>Note the following limitations on a
        /// <c>ChangeResourceRecordSets</c> request:</para> <para>- A request cannot contain more than 100 Change elements.</para> <para>- A request
        /// cannot contain more than 1000 ResourceRecord elements.</para> <para>The sum of the number of characters (including spaces) in all
        /// <c>Value</c> elements in a request cannot exceed 32,000 characters.</para>
        /// </summary>
        /// 
        /// <param name="changeResourceRecordSetsRequest">Container for the necessary parameters to execute the ChangeResourceRecordSets service method
        ///          on AmazonRoute53.</param>
        /// 
        /// <returns>The response from the ChangeResourceRecordSets service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        /// <exception cref="NoSuchHostedZoneException"/>
        /// <exception cref="InvalidChangeBatchException"/>
        /// <exception cref="NoSuchHealthCheckException"/>
        /// <exception cref="PriorRequestNotCompleteException"/>
        ChangeResourceRecordSetsResponse ChangeResourceRecordSets(ChangeResourceRecordSetsRequest changeResourceRecordSetsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeResourceRecordSets operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.ChangeResourceRecordSets"/>
        /// </summary>
        /// 
        /// <param name="changeResourceRecordSetsRequest">Container for the necessary parameters to execute the ChangeResourceRecordSets operation on
        ///          AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndChangeResourceRecordSets operation.</returns>
        IAsyncResult BeginChangeResourceRecordSets(ChangeResourceRecordSetsRequest changeResourceRecordSetsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ChangeResourceRecordSets operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.ChangeResourceRecordSets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangeResourceRecordSets.</param>
        /// 
        /// <returns>Returns a ChangeResourceRecordSetsResult from AmazonRoute53.</returns>
        ChangeResourceRecordSetsResponse EndChangeResourceRecordSets(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateHealthCheck

        /// <summary>
        /// <para> This action creates a new health check.</para> <para> To create a new health check, send a <c>POST</c> request to the
        /// <c>2012-12-12/healthcheck</c> resource. The request body must include an XML document with a <c>CreateHealthCheckRequest</c> element. The
        /// response returns the <c>CreateHealthCheckResponse</c> element that contains metadata about the health check.</para>
        /// </summary>
        /// 
        /// <param name="createHealthCheckRequest">Container for the necessary parameters to execute the CreateHealthCheck service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the CreateHealthCheck service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        /// <exception cref="HealthCheckAlreadyExistsException"/>
        /// <exception cref="TooManyHealthChecksException"/>
        CreateHealthCheckResponse CreateHealthCheck(CreateHealthCheckRequest createHealthCheckRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHealthCheck operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.CreateHealthCheck"/>
        /// </summary>
        /// 
        /// <param name="createHealthCheckRequest">Container for the necessary parameters to execute the CreateHealthCheck operation on
        ///          AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHealthCheck
        ///         operation.</returns>
        IAsyncResult BeginCreateHealthCheck(CreateHealthCheckRequest createHealthCheckRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateHealthCheck operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.CreateHealthCheck"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHealthCheck.</param>
        /// 
        /// <returns>Returns a CreateHealthCheckResult from AmazonRoute53.</returns>
        CreateHealthCheckResponse EndCreateHealthCheck(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateHostedZone

        /// <summary>
        /// <para> This action creates a new hosted zone.</para> <para>To create a new hosted zone, send a <c>POST</c> request to the
        /// <c>2012-12-12/hostedzone</c> resource. The request body must include an XML document with a <c>CreateHostedZoneRequest</c> element. The
        /// response returns the <c>CreateHostedZoneResponse</c> element that contains metadata about the hosted zone.</para> <para>Route 53
        /// automatically creates a default SOA record and four NS records for the zone. The NS records in the hosted zone are the name servers you give
        /// your registrar to delegate your domain to. For more information about SOA and NS records, see <a
        /// href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/SOA-NSrecords.html" >NS and SOA Records that Route 53 Creates for a Hosted
        /// Zone</a> in the <i>Amazon Route 53 Developer Guide</i> .</para> <para>When you create a zone, its initial status is <c>PENDING</c> . This
        /// means that it is not yet available on all DNS servers. The status of the zone changes to <c>INSYNC</c> when the NS and SOA records are
        /// available on all Route 53 DNS servers. </para>
        /// </summary>
        /// 
        /// <param name="createHostedZoneRequest">Container for the necessary parameters to execute the CreateHostedZone service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the CreateHostedZone service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="HostedZoneAlreadyExistsException"/>
        /// <exception cref="InvalidInputException"/>
        /// <exception cref="InvalidDomainNameException"/>
        /// <exception cref="TooManyHostedZonesException"/>
        /// <exception cref="DelegationSetNotAvailableException"/>
        CreateHostedZoneResponse CreateHostedZone(CreateHostedZoneRequest createHostedZoneRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHostedZone operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.CreateHostedZone"/>
        /// </summary>
        /// 
        /// <param name="createHostedZoneRequest">Container for the necessary parameters to execute the CreateHostedZone operation on
        ///          AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHostedZone
        ///         operation.</returns>
        IAsyncResult BeginCreateHostedZone(CreateHostedZoneRequest createHostedZoneRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateHostedZone operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.CreateHostedZone"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHostedZone.</param>
        /// 
        /// <returns>Returns a CreateHostedZoneResult from AmazonRoute53.</returns>
        CreateHostedZoneResponse EndCreateHostedZone(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteHealthCheck

        /// <summary>
        /// <para>This action deletes a health check. To delete a health check, send a <c>DELETE</c> request to the <c>2012-12-12/healthcheck/health
        /// check ID </c> resource.</para> <para><b>IMPORTANT:</b> You can delete a health check only if there are no resource record sets associated
        /// with this health check. If resource record sets are associated with this health check, you must disassociate them before you can delete your
        /// health check. If you try to delete a health check that is associated with resource record sets, Route 53 will deny your request with a
        /// HealthCheckInUse error. For information about disassociating the records from your health check, see ChangeResourceRecordSets.</para>
        /// </summary>
        /// 
        /// <param name="deleteHealthCheckRequest">Container for the necessary parameters to execute the DeleteHealthCheck service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the DeleteHealthCheck service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        /// <exception cref="HealthCheckInUseException"/>
        /// <exception cref="NoSuchHealthCheckException"/>
        DeleteHealthCheckResponse DeleteHealthCheck(DeleteHealthCheckRequest deleteHealthCheckRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHealthCheck operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.DeleteHealthCheck"/>
        /// </summary>
        /// 
        /// <param name="deleteHealthCheckRequest">Container for the necessary parameters to execute the DeleteHealthCheck operation on
        ///          AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHealthCheck
        ///         operation.</returns>
        IAsyncResult BeginDeleteHealthCheck(DeleteHealthCheckRequest deleteHealthCheckRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteHealthCheck operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.DeleteHealthCheck"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHealthCheck.</param>
        /// 
        /// <returns>Returns a DeleteHealthCheckResult from AmazonRoute53.</returns>
        DeleteHealthCheckResponse EndDeleteHealthCheck(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteHostedZone

        /// <summary>
        /// <para>This action deletes a hosted zone. To delete a hosted zone, send a <c>DELETE</c> request to the <c>2012-12-12/hostedzone/hosted zone
        /// ID </c> resource.</para> <para>For more information about deleting a hosted zone, see <a
        /// href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DeleteHostedZone.html" >Deleting a Hosted Zone</a> in the <i>Amazon Route 53
        /// Developer Guide</i> .</para> <para><b>IMPORTANT:</b> You can delete a hosted zone only if there are no resource record sets other than the
        /// default SOA record and NS resource record sets. If your hosted zone contains other resource record sets, you must delete them before you can
        /// delete your hosted zone. If you try to delete a hosted zone that contains other resource record sets, Route 53 will deny your request with a
        /// HostedZoneNotEmpty error. For information about deleting records from your hosted zone, see ChangeResourceRecordSets.</para>
        /// </summary>
        /// 
        /// <param name="deleteHostedZoneRequest">Container for the necessary parameters to execute the DeleteHostedZone service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the DeleteHostedZone service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="HostedZoneNotEmptyException"/>
        /// <exception cref="InvalidInputException"/>
        /// <exception cref="NoSuchHostedZoneException"/>
        /// <exception cref="PriorRequestNotCompleteException"/>
        DeleteHostedZoneResponse DeleteHostedZone(DeleteHostedZoneRequest deleteHostedZoneRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHostedZone operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.DeleteHostedZone"/>
        /// </summary>
        /// 
        /// <param name="deleteHostedZoneRequest">Container for the necessary parameters to execute the DeleteHostedZone operation on
        ///          AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHostedZone
        ///         operation.</returns>
        IAsyncResult BeginDeleteHostedZone(DeleteHostedZoneRequest deleteHostedZoneRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteHostedZone operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.DeleteHostedZone"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHostedZone.</param>
        /// 
        /// <returns>Returns a DeleteHostedZoneResult from AmazonRoute53.</returns>
        DeleteHostedZoneResponse EndDeleteHostedZone(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetChange

        /// <summary>
        /// <para> This action returns the current status of a change batch request. The status is one of the following values:</para> <para>-
        /// <c>PENDING</c> indicates that the changes in this request have not replicated to all Route 53 DNS servers. This is the initial status of all
        /// change batch requests.</para> <para>- <c>INSYNC</c> indicates that the changes have replicated to all Amazon Route 53 DNS servers. </para>
        /// </summary>
        /// 
        /// <param name="getChangeRequest">Container for the necessary parameters to execute the GetChange service method on AmazonRoute53.</param>
        /// 
        /// <returns>The response from the GetChange service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="NoSuchChangeException"/>
        /// <exception cref="InvalidInputException"/>
        GetChangeResponse GetChange(GetChangeRequest getChangeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChange operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.GetChange"/>
        /// </summary>
        /// 
        /// <param name="getChangeRequest">Container for the necessary parameters to execute the GetChange operation on AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChange
        ///         operation.</returns>
        IAsyncResult BeginGetChange(GetChangeRequest getChangeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetChange operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.GetChange"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChange.</param>
        /// 
        /// <returns>Returns a GetChangeResult from AmazonRoute53.</returns>
        GetChangeResponse EndGetChange(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetHealthCheck

        /// <summary>
        /// <para> To retrieve the health check, send a <c>GET</c> request to the <c>2012-12-12/healthcheck/health check ID </c> resource. </para>
        /// </summary>
        /// 
        /// <param name="getHealthCheckRequest">Container for the necessary parameters to execute the GetHealthCheck service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the GetHealthCheck service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        /// <exception cref="NoSuchHealthCheckException"/>
        GetHealthCheckResponse GetHealthCheck(GetHealthCheckRequest getHealthCheckRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheck operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.GetHealthCheck"/>
        /// </summary>
        /// 
        /// <param name="getHealthCheckRequest">Container for the necessary parameters to execute the GetHealthCheck operation on AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHealthCheck
        ///         operation.</returns>
        IAsyncResult BeginGetHealthCheck(GetHealthCheckRequest getHealthCheckRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetHealthCheck operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.GetHealthCheck"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHealthCheck.</param>
        /// 
        /// <returns>Returns a GetHealthCheckResult from AmazonRoute53.</returns>
        GetHealthCheckResponse EndGetHealthCheck(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetHostedZone

        /// <summary>
        /// <para> To retrieve the delegation set for a hosted zone, send a <c>GET</c> request to the <c>2012-12-12/hostedzone/hosted zone ID </c>
        /// resource. The delegation set is the four Route 53 name servers that were assigned to the hosted zone when you created it.</para>
        /// </summary>
        /// 
        /// <param name="getHostedZoneRequest">Container for the necessary parameters to execute the GetHostedZone service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the GetHostedZone service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        /// <exception cref="NoSuchHostedZoneException"/>
        GetHostedZoneResponse GetHostedZone(GetHostedZoneRequest getHostedZoneRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZone operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.GetHostedZone"/>
        /// </summary>
        /// 
        /// <param name="getHostedZoneRequest">Container for the necessary parameters to execute the GetHostedZone operation on AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHostedZone
        ///         operation.</returns>
        IAsyncResult BeginGetHostedZone(GetHostedZoneRequest getHostedZoneRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetHostedZone operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.GetHostedZone"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostedZone.</param>
        /// 
        /// <returns>Returns a GetHostedZoneResult from AmazonRoute53.</returns>
        GetHostedZoneResponse EndGetHostedZone(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListHealthChecks

        /// <summary>
        /// <para> To retrieve a list of your health checks, send a <c>GET</c> request to the <c>2012-12-12/healthcheck</c> resource. The response to
        /// this request includes a <c>HealthChecks</c> element with zero, one, or multiple <c>HealthCheck</c> child elements. By default, the list of
        /// health checks is displayed on a single page. You can control the length of the page that is displayed by using the <c>MaxItems</c>
        /// parameter. You can use the <c>Marker</c> parameter to control the health check that the list begins with. </para> <para><b>NOTE:</b> Amazon
        /// Route 53 returns a maximum of 100 items. If you set MaxItems to a value greater than 100, Amazon Route 53 returns only the first 100.</para>
        /// </summary>
        /// 
        /// <param name="listHealthChecksRequest">Container for the necessary parameters to execute the ListHealthChecks service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        ListHealthChecksResponse ListHealthChecks(ListHealthChecksRequest listHealthChecksRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHealthChecks operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.ListHealthChecks"/>
        /// </summary>
        /// 
        /// <param name="listHealthChecksRequest">Container for the necessary parameters to execute the ListHealthChecks operation on
        ///          AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHealthChecks
        ///         operation.</returns>
        IAsyncResult BeginListHealthChecks(ListHealthChecksRequest listHealthChecksRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListHealthChecks operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.ListHealthChecks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHealthChecks.</param>
        /// 
        /// <returns>Returns a ListHealthChecksResult from AmazonRoute53.</returns>
        ListHealthChecksResponse EndListHealthChecks(IAsyncResult asyncResult);

        /// <summary>
        /// <para> To retrieve a list of your health checks, send a <c>GET</c> request to the <c>2012-12-12/healthcheck</c> resource. The response to
        /// this request includes a <c>HealthChecks</c> element with zero, one, or multiple <c>HealthCheck</c> child elements. By default, the list of
        /// health checks is displayed on a single page. You can control the length of the page that is displayed by using the <c>MaxItems</c>
        /// parameter. You can use the <c>Marker</c> parameter to control the health check that the list begins with. </para> <para><b>NOTE:</b> Amazon
        /// Route 53 returns a maximum of 100 items. If you set MaxItems to a value greater than 100, Amazon Route 53 returns only the first 100.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        ListHealthChecksResponse ListHealthChecks();
        
        #endregion
        
    

        #region ListHostedZones

        /// <summary>
        /// <para> To retrieve a list of your hosted zones, send a <c>GET</c> request to the <c>2012-12-12/hostedzone</c> resource. The response to this
        /// request includes a <c>HostedZones</c> element with zero, one, or multiple <c>HostedZone</c> child elements. By default, the list of hosted
        /// zones is displayed on a single page. You can control the length of the page that is displayed by using the <c>MaxItems</c> parameter. You
        /// can use the <c>Marker</c> parameter to control the hosted zone that the list begins with. </para> <para><b>NOTE:</b> Amazon Route 53 returns
        /// a maximum of 100 items. If you set MaxItems to a value greater than 100, Amazon Route 53 returns only the first 100.</para>
        /// </summary>
        /// 
        /// <param name="listHostedZonesRequest">Container for the necessary parameters to execute the ListHostedZones service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        ListHostedZonesResponse ListHostedZones(ListHostedZonesRequest listHostedZonesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZones operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.ListHostedZones"/>
        /// </summary>
        /// 
        /// <param name="listHostedZonesRequest">Container for the necessary parameters to execute the ListHostedZones operation on
        ///          AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHostedZones
        ///         operation.</returns>
        IAsyncResult BeginListHostedZones(ListHostedZonesRequest listHostedZonesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListHostedZones operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.ListHostedZones"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHostedZones.</param>
        /// 
        /// <returns>Returns a ListHostedZonesResult from AmazonRoute53.</returns>
        ListHostedZonesResponse EndListHostedZones(IAsyncResult asyncResult);

        /// <summary>
        /// <para> To retrieve a list of your hosted zones, send a <c>GET</c> request to the <c>2012-12-12/hostedzone</c> resource. The response to this
        /// request includes a <c>HostedZones</c> element with zero, one, or multiple <c>HostedZone</c> child elements. By default, the list of hosted
        /// zones is displayed on a single page. You can control the length of the page that is displayed by using the <c>MaxItems</c> parameter. You
        /// can use the <c>Marker</c> parameter to control the hosted zone that the list begins with. </para> <para><b>NOTE:</b> Amazon Route 53 returns
        /// a maximum of 100 items. If you set MaxItems to a value greater than 100, Amazon Route 53 returns only the first 100.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        ListHostedZonesResponse ListHostedZones();
        
        #endregion
        
    

        #region ListResourceRecordSets

        /// <summary>
        /// <para>Imagine all the resource record sets in a zone listed out in front of you. Imagine them sorted lexicographically first by DNS name
        /// (with the labels reversed, like "com.amazon.www" for example), and secondarily, lexicographically by record type. This operation retrieves
        /// at most MaxItems resource record sets from this list, in order, starting at a position specified by the Name and Type arguments:</para>
        /// <ul>
        /// <li>If both Name and Type are omitted, this means start the results at the first RRSET in the HostedZone.</li>
        /// <li>If Name is specified but Type is omitted, this means start the results at the first RRSET in the list whose name is greater than or
        /// equal to Name. </li>
        /// <li>If both Name and Type are specified, this means start the results at the first RRSET in the list whose name is greater than or equal to
        /// Name and whose type is greater than or equal to Type.</li>
        /// <li>It is an error to specify the Type but not the Name.</li>
        /// 
        /// </ul>
        /// <para>Use ListResourceRecordSets to retrieve a single known record set by specifying the record set's name and type, and setting MaxItems =
        /// 1</para> <para>To retrieve all the records in a HostedZone, first pause any processes making calls to ChangeResourceRecordSets. Initially
        /// call ListResourceRecordSets without a Name and Type to get the first page of record sets. For subsequent calls, set Name and Type to the
        /// NextName and NextType values returned by the previous response. </para> <para>In the presence of concurrent ChangeResourceRecordSets calls,
        /// there is no consistency of results across calls to ListResourceRecordSets. The only way to get a consistent multi-page snapshot of all
        /// RRSETs in a zone is to stop making changes while pagination is in progress.</para> <para>However, the results from ListResourceRecordSets
        /// are consistent within a page. If MakeChange calls are taking place concurrently, the result of each one will either be completely visible in
        /// your results or not at all. You will not see partial changes, or changes that do not ultimately succeed. (This follows from the fact that
        /// MakeChange is atomic) </para> <para>The results from ListResourceRecordSets are strongly consistent with ChangeResourceRecordSets. To be
        /// precise, if a single process makes a call to ChangeResourceRecordSets and receives a successful response, the effects of that change will be
        /// visible in a subsequent call to ListResourceRecordSets by that process.</para>
        /// </summary>
        /// 
        /// <param name="listResourceRecordSetsRequest">Container for the necessary parameters to execute the ListResourceRecordSets service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the ListResourceRecordSets service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        /// <exception cref="NoSuchHostedZoneException"/>
        ListResourceRecordSetsResponse ListResourceRecordSets(ListResourceRecordSetsRequest listResourceRecordSetsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceRecordSets operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.ListResourceRecordSets"/>
        /// </summary>
        /// 
        /// <param name="listResourceRecordSetsRequest">Container for the necessary parameters to execute the ListResourceRecordSets operation on
        ///          AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListResourceRecordSets operation.</returns>
        IAsyncResult BeginListResourceRecordSets(ListResourceRecordSetsRequest listResourceRecordSetsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListResourceRecordSets operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53.ListResourceRecordSets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceRecordSets.</param>
        /// 
        /// <returns>Returns a ListResourceRecordSetsResult from AmazonRoute53.</returns>
        ListResourceRecordSetsResponse EndListResourceRecordSets(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
