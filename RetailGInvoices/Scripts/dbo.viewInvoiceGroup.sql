CREATE VIEW [dbo].[viewInvoiceGroup]
	AS 
SELECT
	 invH.Description as InvoiceHeading,
	 inv.Heading as InvoiceHeadingId,
	 sum(inv.GrossAmount) as InvoiceGross,
	 sum(inv.VATAmount)	 as InvoiceVAT,
	 sum(inv.NetAmount)	 as InvoiceNet,
	 inv.PaymentTypeID as InvoicePaymentId,
	 CAST(inv.Heading as varchar(10)) +  CAST(inv.PaymentTypeID as varchar(10)) as ViewGroupID,
	 inv.CompanyID as InvoiceCompanyId
FROM dbo.Invoice inv,
	dbo.InvoiceHeading invH
WHERE
	invH.Id = inv.Heading
Group by
	inv.Heading,
	invH.Description,
	inv.PaymentTypeID,
	inv.CompanyID;